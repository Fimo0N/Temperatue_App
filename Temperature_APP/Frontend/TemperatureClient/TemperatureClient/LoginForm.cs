using System;
using System.Net;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace items
{
    public partial class LoginForm : Form
    {
        private Form1 mainForm; 
        private string URL;     
        public LoginForm(Form1 mainForm, string url)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.URL = url;

            loginButton.Click += loginButton_Click;
        }

      
        public class LoginResponse
        {
            public string token { get; set; }
        }

      
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim();
            string password = passwordText.Text.Trim();

           
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            var client = new RestClient($"{URL}");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { username, password });

            try
            {
               
                IRestResponse response = client.Execute(request);

               
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = JsonConvert.DeserializeObject<LoginResponse>(response.Content);

                    if (!string.IsNullOrEmpty(result.token))
                    {
                        
                        string token = result.token;
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        mainForm.SetAccessToken(token);
                        this.Close();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve the token. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Server error: {response.StatusDescription}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
