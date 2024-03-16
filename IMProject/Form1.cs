using System;
using System.Windows.Forms;
using IMProject.User_Control;
using MySql.Data.MySqlClient;

namespace IMProject
{
    public partial class login_form : Form
    {
        private MySqlConnection mySqlConnection;
        private string connectionString = "server=127.0.0.1; user=root; database=icwa; password=";

        public login_form()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(connectionString);
        }
        private void login_btn_Click_1(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            if (VerifyCredentials(username, password))
            {
                // Credentials are correct, show the Dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
               
                this.Hide();
                
            }
            else
            {
                // Credentials are incorrect, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyCredentials(string username, string password)
        {
            try
            {
                mySqlConnection.Open();
                string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while verifying credentials: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
