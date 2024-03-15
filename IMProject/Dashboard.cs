using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height; 
            
        }
            
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result=MessageBox.Show("Do you really want to log out?", "Log Out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(sales_btn);
        }

        private void delivery_btn_Click(object sender, EventArgs e)
        {
            MovePanel(delivery_btn);
        }

        private void transaction_btn_Click(object sender, EventArgs e)
        {
            MovePanel(transaction_btn);
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            MovePanel(customers_btn);
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            MovePanel(employee_btn);
        }

        private void userControlSales1_Load(object sender, EventArgs e)
        {

        }
    }
}
