using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMProject.User_Control
{
    public partial class AddCustomer : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; user=root; database=icwa; password=";
        public AddCustomer()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
           
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string customerName = custNametxt.Text;
            string customerPhone = custPhonetxt.Text;
            string customerAddress = custAddresstxt.Text;

            string query = "INSERT INTO tbl_customer (customer_name, customer_phone, customer_address) VALUES (@name, @phone, @address)";
            

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", customerName);
                command.Parameters.AddWithValue("@phone", customerPhone);
                command.Parameters.AddWithValue("@address", customerAddress);
                command.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
