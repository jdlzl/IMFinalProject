namespace IMProject
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employee_btn = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.customers_btn = new System.Windows.Forms.Button();
            this.transaction_btn = new System.Windows.Forms.Button();
            this.delivery_btn = new System.Windows.Forms.Button();
            this.sales_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlSales1 = new IMProject.User_Control.UserControlSales();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 231);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.employee_btn);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.transaction_btn);
            this.panel2.Controls.Add(this.delivery_btn);
            this.panel2.Controls.Add(this.sales_btn);
            this.panel2.Location = new System.Drawing.Point(1, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 486);
            this.panel2.TabIndex = 1;
            // 
            // employee_btn
            // 
            this.employee_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_btn.Location = new System.Drawing.Point(20, 255);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(197, 49);
            this.employee_btn.TabIndex = 5;
            this.employee_btn.Text = "Employees";
            this.employee_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_btn.UseVisualStyleBackColor = true;
            this.employee_btn.Click += new System.EventHandler(this.employee_btn_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSlide.Location = new System.Drawing.Point(0, 35);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(14, 47);
            this.panelSlide.TabIndex = 0;
            // 
            // customers_btn
            // 
            this.customers_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.Location = new System.Drawing.Point(20, 200);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(197, 49);
            this.customers_btn.TabIndex = 4;
            this.customers_btn.Text = "Customers";
            this.customers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // transaction_btn
            // 
            this.transaction_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_btn.Location = new System.Drawing.Point(20, 145);
            this.transaction_btn.Name = "transaction_btn";
            this.transaction_btn.Size = new System.Drawing.Size(197, 49);
            this.transaction_btn.TabIndex = 3;
            this.transaction_btn.Text = "Transactions";
            this.transaction_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_btn.UseVisualStyleBackColor = true;
            this.transaction_btn.Click += new System.EventHandler(this.transaction_btn_Click);
            // 
            // delivery_btn
            // 
            this.delivery_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delivery_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_btn.Location = new System.Drawing.Point(20, 90);
            this.delivery_btn.Name = "delivery_btn";
            this.delivery_btn.Size = new System.Drawing.Size(197, 49);
            this.delivery_btn.TabIndex = 2;
            this.delivery_btn.Text = "Delivery";
            this.delivery_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delivery_btn.UseVisualStyleBackColor = true;
            this.delivery_btn.Click += new System.EventHandler(this.delivery_btn_Click);
            // 
            // sales_btn
            // 
            this.sales_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_btn.Location = new System.Drawing.Point(20, 35);
            this.sales_btn.Name = "sales_btn";
            this.sales_btn.Size = new System.Drawing.Size(197, 49);
            this.sales_btn.TabIndex = 1;
            this.sales_btn.Text = "Sales";
            this.sales_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales_btn.UseVisualStyleBackColor = true;
            this.sales_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 456);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userControlSales1);
            this.panel3.Location = new System.Drawing.Point(266, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1661, 713);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // userControlSales1
            // 
            this.userControlSales1.Location = new System.Drawing.Point(-1, 0);
            this.userControlSales1.Name = "userControlSales1";
            this.userControlSales1.Size = new System.Drawing.Size(1666, 713);
            this.userControlSales1.TabIndex = 0;
            this.userControlSales1.Load += new System.EventHandler(this.userControlSales1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 712);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button transaction_btn;
        private System.Windows.Forms.Button delivery_btn;
        private System.Windows.Forms.Button sales_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button employee_btn;
        private User_Control.UserControlSales userControlSales1;
    }
}