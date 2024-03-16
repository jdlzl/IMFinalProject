using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IMProject.User_Control
{
    public partial class UserControlSales : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; user=root; database=icwa; password=";
        private DataTable dataTable3 = new DataTable();


        public UserControlSales()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);


            LoadData();
            LoadData1();
            LoadData2();
            LoadData3();


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
        private void LoadData2()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_customer";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable2 = new DataTable();
                adapter.Fill(dataTable2);
                customers_dataGrid.DataSource = dataTable2;
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
        private void LoadData3()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_delivery";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable3 = new DataTable();
                adapter.Fill(dataTable3);
                delivery_dataGrid.DataSource = dataTable3;
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
        private void mineralBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mineralBtn.Checked)
            {
                waterTypetxt.Text = "Mineral Water";
                int price = 20;
                initialPricetxt.Text = ("₱" + price.ToString());
            }

        }

        private void purBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (purBtn.Checked)
            {
                waterTypetxt.Text = "Purified Water";
                int price = 25;
                initialPricetxt.Text = ("₱" + price.ToString());
            }

        }

        private void alBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (alBtn.Checked)
            {
                waterTypetxt.Text = "Alkaline Water";
                int price = 50;
                initialPricetxt.Text = ("₱" + price.ToString());
            }
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
                changeText.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerIDtxt.Text);
            int typeId = GetSelectedTypeId();
            int quantity1 = Convert.ToInt32(quantity.Value);
            decimal totalPriceTxt = Convert.ToDecimal(totalPrice.Text.Replace("₱", "").Trim());
            DateTime date = DateTime.Now;
            int paymentMethod = GetSelectedPaymentMethod();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert a new record into tbl_transaction
                    string insertTransactionQuery = @"INSERT INTO tbl_transaction (transaction_date, payment_method) VALUES (@date, @paymentMethod); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand transactionCommand = new MySqlCommand(insertTransactionQuery, connection))
                    {
                        transactionCommand.Parameters.AddWithValue("@date", date);
                        transactionCommand.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                        int transactionId = Convert.ToInt32(transactionCommand.ExecuteScalar());

                        // Insert a new record into tbl_transaction_details using the obtained transactionId
                        string insertTransactionDetailsQuery = @"INSERT INTO tbl_transaction_details (transaction_id, customer_id, type_id, quantity, total_price, date, payment_method) 
                                                          VALUES (@transactionId, @customerId, @typeId, @quantity, @totalPrice, @date, @paymentmethod)";

                        using (MySqlCommand transactionDetailsCommand = new MySqlCommand(insertTransactionDetailsQuery, connection))
                        {
                            transactionDetailsCommand.Parameters.AddWithValue("@transactionId", transactionId);
                            transactionDetailsCommand.Parameters.AddWithValue("@customerId", customerId);
                            transactionDetailsCommand.Parameters.AddWithValue("@typeId", typeId);
                            transactionDetailsCommand.Parameters.AddWithValue("@quantity", quantity1);
                            transactionDetailsCommand.Parameters.AddWithValue("@totalPrice", totalPriceTxt);
                            transactionDetailsCommand.Parameters.AddWithValue("@date", date);
                            transactionDetailsCommand.Parameters.AddWithValue("@paymentmethod", paymentMethod);

                            transactionDetailsCommand.ExecuteNonQuery();

                            LoadData();
                            MessageBox.Show("Transaction added successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding transaction: " + ex.Message);
            }
        }

        private int GetSelectedTypeId()
        {
            if (mineralBtn.Checked)
            {
                return 1;
            }
            else if (purBtn.Checked)
            {
                return 2;
            }
            else if (alBtn.Checked)
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
            if (cashRadiobtn.Checked)
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

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string searchText = searchTxtBox.Text.Trim();
                string query;

                // Check if the search box is empty. If it is, select all customers.
                // Otherwise, select customers based on the search text.
                if (string.IsNullOrEmpty(searchText))
                {
                    query = "SELECT * FROM tbl_customer";
                }
                else
                {
                    query = "SELECT * FROM tbl_customer WHERE customer_name LIKE @searchText";
                }

                MySqlCommand command = new MySqlCommand(query, connection);

                // Only add the parameter if there's a search text to avoid errors.
                if (!string.IsNullOrEmpty(searchText))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable4 = new DataTable();
                adapter.Fill(dataTable4);

                customers_dataGrid.DataSource = dataTable4;
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


        private void clearBtn_Click(object sender, EventArgs e)
        {
            quantity.ValueChanged -= quantity_ValueChanged;

            // Now safely change the value without triggering the event
            quantity.Value = 1;

            totalPrice.Text = "";
            changeText.Text = "";
            textBox1.Text = "";
            waterTypetxt.Text = "";
            initialPricetxt.Text = "";
            customerIDtxt.Text = "";
            mineralBtn.Checked = false;
            purBtn.Checked = false;
            alBtn.Checked = false;
            cashRadiobtn.Checked = false;
            gcashRadiobtn.Checked = false;

            quantity.ValueChanged += quantity_ValueChanged;



        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

            AddCustomer add = new AddCustomer();
            add.Show();
            this.ParentForm.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Iterate through the DataGridView rows
            foreach (DataGridViewRow row in customers_dataGrid.Rows)
            {
                // Check if the row has been modified
                if (row.Cells["customer_name"].Value != null) // Assuming 'customer_name' is a column
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            // Prepare the UPDATE command. Modify this according to your actual columns.
                            string cmdText = @"UPDATE tbl_customer SET customer_name = @customerName, customer_phone = @phone, customer_address = @address WHERE customer_id = @customerId";
                            using (MySqlCommand command = new MySqlCommand(cmdText, connection))
                            {
                                // Add parameters to prevent SQL Injection
                                command.Parameters.AddWithValue("@customerName", row.Cells["customer_name"].Value);
                                command.Parameters.AddWithValue("@phone", row.Cells["customer_phone"].Value); // Assuming you have a 'phone' column
                                command.Parameters.AddWithValue("@address", row.Cells["customer_address"].Value); // Assuming you have an 'address' column
                                command.Parameters.AddWithValue("@customerId", row.Cells["customer_id"].Value); // Your primary key column

                                // Execute the command
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating record: " + ex.Message);
                    }
                }
            }

            MessageBox.Show("All changes saved successfully.");
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (customers_dataGrid.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView is bound to a DataTable
                DataRowView rowView = customers_dataGrid.SelectedRows[0].DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    int customerId = Convert.ToInt32(row["customer_id"]); // Adjust the column name as per your schema

                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            // Prepare the DELETE command to remove the row from the database
                            string cmdText = "DELETE FROM tbl_customer WHERE customer_id = @customerId";
                            using (MySqlCommand command = new MySqlCommand(cmdText, connection))
                            {
                                // Use parameters to avoid SQL Injection
                                command.Parameters.AddWithValue("@customerId", customerId);

                                // Execute the command
                                int result = command.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    // If the database row is successfully deleted, remove the row from the DataGridView
                                    customers_dataGrid.Rows.RemoveAt(customers_dataGrid.SelectedRows[0].Index);

                                    MessageBox.Show("Record deleted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("The record could not be deleted.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (transaction_details.SelectedRows.Count > 0)
            {
                
                int transactionId = Convert.ToInt32(transaction_details.SelectedRows[0].Cells["transaction_id"].Value);

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                       
                        connection.Open();

                        string cmdText = "DELETE FROM tbl_transaction_details WHERE transaction_id = @transactionId";
                        using (MySqlCommand command = new MySqlCommand(cmdText, connection))
                        {
                           
                            command.Parameters.AddWithValue("@transactionId", transactionId);

                           
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                
                                transaction_details.Rows.RemoveAt(transaction_details.SelectedRows[0].Index);

                                MessageBox.Show("Record deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("The record could not be deleted.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void UserControlSales_Load(object sender, EventArgs e)
        {

        }

        private void tranSearchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string searchTxt = tranSearchTxt.Text.Trim();
                string query;

               
                if (string.IsNullOrEmpty(searchTxt))
                {
                    query = "SELECT * FROM tbl_transaction_details";
                }
                else
                {
                    query = "SELECT * FROM tbl_transaction_details WHERE transaction_id LIKE @searchText";
                }

                MySqlCommand command = new MySqlCommand(query, connection);

                
                if (!string.IsNullOrEmpty(searchTxt))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchTxt + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable5 = new DataTable();
                adapter.Fill(dataTable5);

                transaction_details.DataSource = dataTable5;
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

        private void addDelivery_Click(object sender, EventArgs e)
        {

            AddDelivery add = new AddDelivery();
            add.Show();
            this.ParentForm.Hide();
        }

        private void customers_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delDelivery_Click(object sender, EventArgs e)
        {
            if (delivery_dataGrid.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView is bound to a DataTable
                DataGridViewRow selectedRow = delivery_dataGrid.SelectedRows[0];
                int transactionId = Convert.ToInt32(selectedRow.Cells["transaction_id"].Value);

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Prepare the DELETE command to remove the row from the database
                        string cmdText = "DELETE FROM tbl_delivery WHERE transaction_id = @transactionId";
                        using (MySqlCommand command = new MySqlCommand(cmdText, connection))
                        {
                            // Use parameters to avoid SQL Injection
                            command.Parameters.AddWithValue("@transactionId", transactionId);

                            // Execute the command
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                // If the database row is successfully deleted, remove the row from the DataGridView
                                delivery_dataGrid.Rows.RemoveAt(selectedRow.Index);

                                MessageBox.Show("Record deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("The record could not be deleted.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
