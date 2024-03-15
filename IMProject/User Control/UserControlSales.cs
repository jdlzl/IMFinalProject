using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IMProject.User_Control
{
    public partial class UserControlSales : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; user=root; database=icwa; password=";

        public UserControlSales()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);

            // Load data into DataGridView
            LoadData();
            LoadData1();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_transaction_details";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                transaction_details.DataSource = dataTable;
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
        private void LoadData1()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_water_type";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable1 = new DataTable();
                adapter.Fill(dataTable1);
                water_type.DataSource = dataTable1;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            waterTypetxt.Text = "Mineral Water";
            int price = 20;
            initialPricetxt.Text= ("₱" + price.ToString());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            waterTypetxt.Text = "Purified Water";
            int price = 25;
            initialPricetxt.Text = ("₱"+price.ToString());

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            waterTypetxt.Text = "Alkaline Water";
            int price = 50;
            initialPricetxt.Text = ("₱" + price.ToString());
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            string priceString = initialPricetxt.Text.Replace("₱", "");

            // Parse the value from the pricetxt TextBox
            if (decimal.TryParse(priceString, out decimal price))
            {
                // Multiply the value from numericUpDown1 with the price
                decimal total = quantity.Value * price;

                // Display the total in another TextBox or wherever you need it
                totalPrice.Text = ("₱" + total.ToString());
            }
            else
            {
                // Handle invalid price input
                MessageBox.Show("Invalid price input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string priceString = totalPrice.Text.Replace("₱", "");
            if (decimal.TryParse(priceString, out decimal totalPriceValue))
            {
                // Parse the value from the textInput TextBox
                if (decimal.TryParse(textBox1.Text, out decimal inputValue))
                {
                    // Subtract the inputValue from totalPriceValue
                    decimal change = inputValue - totalPriceValue;

                    // Display the result in the changeText Label
                    changeText.Text = ("₱" + change.ToString());
                }
                else
                {
                    // Handle invalid input in textInput
                    changeText.Text = "Invalid input";
                }
            }
            else
            {
                // Handle invalid input in totalPrice
                changeText.Text = "Invalid total price";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Assuming customerIDtxt, radioButton, numericUpandDown, totalPrice, and paymentRadioButton
                // are the controls you have in your form to get the values.

                string query = "INSERT INTO tbl_transaction_details (customer_id, type_id, quantity, total_price, date, payment_method) " +
                               "VALUES (@customer_id, @type_id, @quantity, @total_price, @date, @payment_method)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", customerIDtxt.Text);
                command.Parameters.AddWithValue("@type_id", GetSelectedTypeId());
                command.Parameters.AddWithValue("@quantity", quantity.Value);
                command.Parameters.AddWithValue("@total_price", totalPrice.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@payment_method", GetSelectedPaymentMethod());

                command.ExecuteNonQuery();
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
        private int GetSelectedTypeId()
        {
            if (radioButton1.Checked)
            {
                return 1;
            }
            else if (radioButton2.Checked)
            {
                return 2;
            }
            else if (radioButton3.Checked)
            {
                return 3;
            }
            else
            {
                MessageBox.Show("Please select a water type.");
                return -1;
            }
        }

        private int GetSelectedPaymentMethod()
        {
            if(cashRadiobtn.Checked)
            {
                return 1;
            }
            else if (gcashRadiobtn.Checked)
            {
                return 2;
            }
            else
            {
                MessageBox.Show("Please select a payment method.");
                return -1;
            }
        }
    
    }
}
