using IMProject.User_Control;
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
                Application.Exit();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(sales_btn);
            userControlEmployees1.Hide();
            userControlSales2.Show();
            
        }

        private void delivery_btn_Click(object sender, EventArgs e)
        {
            MovePanel(delivery_btn);
            //userControlSales2.Hide();
        }

        private void transaction_btn_Click(object sender, EventArgs e)
        {
            MovePanel(transaction_btn);
           // userControlSales2.Hide();
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            MovePanel(employee_btn);
            userControlSales2.Hide();
            userControlEmployees1.Show();
        }

        private void userControlSales1_Load(object sender, EventArgs e)
        {

        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the closing reason is not due to application exit
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                // Ask for confirmation only if the user clicked the "X" button
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Close the application
                        Application.Exit();
                    }
                    else
                    {
                        // Cancel the form closing event
                        e.Cancel = true;
                    }
                }
                else
                {
                    // Close the application for other reasons (e.g., "Log Out" clicked)
                    Application.Exit();
                }
            }
        }

        private void userControlSales2_Load(object sender, EventArgs e)
        {
            
        }

        private void userControlSales3_Load(object sender, EventArgs e)
        {

        }

        private void userControlEmployees1_Load(object sender, EventArgs e)
        {

        }
    }
}
