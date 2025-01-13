using items;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TemperatureClient
{
    public partial class Form2 : Form
    {
        
        private string URL = "http://localhost:3000"; 

        public Form2()
        {
            InitializeComponent();
        }

       
        //Query 1
        private void buttonThreshold_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var client = new RestClient(URL);
            string threshold = thresholdTextBox.Text;

            if (string.IsNullOrEmpty(threshold) || !double.TryParse(threshold, out double thresholdValue))
            {
                MessageBox.Show("Please enter a valid temperature threshold.");
                return;
            }

            var request = new RestRequest($"/records/above/{thresholdValue}", Method.GET);

            try
            {
                IRestResponse<List<TemperatureRecord>> response = client.Execute<List<TemperatureRecord>>(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (var record in response.Data)
                    {
                        DateTime recordDate = DateTime.Parse(record.rdate);
                        string formattedDate = recordDate.ToString("yyyy-MM-dd");
                        listBox1.Items.Add($"Date: {formattedDate}, Temp: {record.rvalue}");
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to fetch data. Server returned: {response.StatusDescription}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            ClearTextBoxes();
        }

       // QUery 2
        private void buttonMinMax_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var client = new RestClient(URL);

            var request = new RestRequest("/testextremes", Method.GET);

            try
            {
                IRestResponse<MinMaxTemperatures> response = client.Execute<MinMaxTemperatures>(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    listBox1.Items.Add($"Min Temp: {response.Data.min_temp}, Max Temp: {response.Data.max_temp}");
                }
                else
                {
                    MessageBox.Show($"Failed to fetch data. Server returned: {response.StatusDescription}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            ClearTextBoxes();
        }

        // Query3
        private void buttonMinTempsYear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var client = new RestClient(URL);
            string year = yearTextBox.Text;

            if (string.IsNullOrEmpty(year) || !int.TryParse(year, out int yearValue))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            var request = new RestRequest($"/records/min/{yearValue}", Method.GET);

            try
            {
                IRestResponse<List<TemperatureRecord>> response = client.Execute<List<TemperatureRecord>>(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (var record in response.Data)
                    {
                        DateTime recordDate = DateTime.Parse(record.rdate);
                        string formattedDate = recordDate.ToString("yyyy-MM-dd");
                        listBox1.Items.Add($"Place: {record.sname}, Date: {formattedDate}, Min Temp: {record.min_temp}");
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to fetch data. Server returned: {response.StatusDescription}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            ClearTextBoxes();
        }

       
        private void ClearTextBoxes()
        {
            thresholdTextBox.Clear();
            yearTextBox.Clear();
        }

     
        public class TemperatureRecord
        {
            public string rdate { get; set; }
            public double rvalue { get; set; }
            public string sname { get; set; }
            public double min_temp { get; set; }
        }

        public class MinMaxTemperatures
        {
            public double min_temp { get; set; }
            public double max_temp { get; set; }
        }
    }
}
