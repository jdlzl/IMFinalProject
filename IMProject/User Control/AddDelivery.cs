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
    public partial class AddDelivery : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; user=root; database=icwa; password=";
        public AddDelivery()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string transID = transIDtxt.Text;
            string custID = custIDtxt.Text;
            DateTime deliveryDate = delDate.Value;
            string deliveryStatus = delStattxt.Text;
            string employeeID = empIDtxt.Text;

            string query = "INSERT INTO tbl_delivery (transaction_id, customer_id, delivery_date, delivery_status, employee_id) VALUES (@transid, @custid, @deldate, @delstat, @empid)";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@transid", transID); // Assuming transID is customer name
                command.Parameters.AddWithValue("@custid", custID); // Assuming custID is customer phone
                command.Parameters.AddWithValue("@deldate", deliveryDate);
                command.Parameters.AddWithValue("@delstat", deliveryStatus);
                command.Parameters.AddWithValue("@empid", employeeID);// Assuming customerAddress is customer address
                command.ExecuteNonQuery();
                MessageBox.Show("Delivery added successfully.");

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
