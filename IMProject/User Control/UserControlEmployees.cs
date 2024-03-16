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
    public partial class UserControlEmployees : UserControl
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1; user=root; database=icwa; password=";
        public UserControlEmployees()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_employee";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                employee_gridView.DataSource = dataTable;
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
