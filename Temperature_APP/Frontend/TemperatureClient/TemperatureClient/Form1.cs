using System;
using System.Windows.Forms;
using RestSharp;
using TemperatureClient;

namespace items
{
    public partial class Form1 : Form
    {
        private string URL = "http://localhost:3000";
        private string accessToken;
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public string AccessToken
        {
            get { return accessToken; }
            set { accessToken = value; }
        }

        public void SetAccessToken(string token)
        {
            this.accessToken = token;
        }

        private void IncludeAuthToken(RestRequest request)
        {
            if (!string.IsNullOrEmpty(AccessToken))
            {
                request.AddHeader("Authorization", $"Bearer {AccessToken}");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            LoginForm loginForm = new LoginForm(this, $"{URL}/login");
            loginForm.ShowDialog();
        }

       // Get
        private async void buttonFetchRecords_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text; 
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }

            var client = new RestClient(URL);
            var request = new RestRequest($"records/{id}", Method.GET);

            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    var record = Newtonsoft.Json.JsonConvert.DeserializeObject<TemperatureRecord>(response.Content);
                    listBox1.Items.Clear();
                    DateTime recordDate = DateTime.Parse(record.rdate);
                    string formattedDate = recordDate.ToString("yyyy-MM-dd");
                    listBox1.Items.Add($"Date: {formattedDate}, Value: {record.rvalue}, Type: {record.rtype}, Place ID: {record.placeid}");
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Post --- Protected
        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("records", Method.POST);
            IncludeAuthToken(request);

            var newRecord = new
            {
                rvalue = rvalueTextBox.Text,
                rtype = rtypeTextBox.Text,                      
                rdate = rdateTextBox.Text,  
                placeid = placeidTextBox.Text  
            };

            request.AddJsonBody(newRecord);

            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    MessageBox.Show("Record created successfully");
                }
                else
                {
                    MessageBox.Show("Error creating record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Put -- Protected
        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text; 
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }

            var client = new RestClient(URL);
            var request = new RestRequest($"records/{id}", Method.PUT);
            IncludeAuthToken(request);

            var updatedRecord = new
            {
                rvalue = rvalueTextBox.Text, 
                rtype = rtypeTextBox.Text,                       
                rdate = rdateTextBox.Text,  
                placeid = placeidTextBox.Text  
            };

            request.AddJsonBody(updatedRecord);

            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    MessageBox.Show("Record updated successfully");
                }
                else
                {
                    MessageBox.Show("Error updating record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Delete -- Protected
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;  
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }

            var client = new RestClient(URL);
            var request = new RestRequest($"records/{id}", Method.DELETE);
            IncludeAuthToken(request);

            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    MessageBox.Show("Record deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error deleting record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();

            
            form2.ShowDialog();
        }

        public class TemperatureRecord
        {
            public string rdate { get; set; }
            public double rvalue { get; set; }
            public string rtype { get; set; }
            public int placeid { get; set; }
        }
    }
}
