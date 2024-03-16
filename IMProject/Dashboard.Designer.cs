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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.employee_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.transaction_btn = new System.Windows.Forms.Button();
            this.delivery_btn = new System.Windows.Forms.Button();
            this.sales_btn = new System.Windows.Forms.Button();
            this.userControlEmployees1 = new IMProject.User_Control.UserControlEmployees();
            this.userControlSales3 = new IMProject.User_Control.UserControlSales();
            this.userControlSales2 = new IMProject.User_Control.UserControlSales();
            this.userControlSales1 = new IMProject.User_Control.UserControlSales();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 231);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::IMProject.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.employee_btn);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.transaction_btn);
            this.panel2.Controls.Add(this.delivery_btn);
            this.panel2.Controls.Add(this.sales_btn);
            this.panel2.Location = new System.Drawing.Point(1, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 860);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IMProject.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(53, 741);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // employee_btn
            // 
            this.employee_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_btn.Location = new System.Drawing.Point(20, 113);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(197, 49);
            this.employee_btn.TabIndex = 5;
            this.employee_btn.Text = "Employees";
            this.employee_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_btn.UseVisualStyleBackColor = true;
            this.employee_btn.Click += new System.EventHandler(this.employee_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(94, 741);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 28);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSlide.Location = new System.Drawing.Point(0, 35);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(14, 47);
            this.panelSlide.TabIndex = 0;
            // 
            // transaction_btn
            // 
            this.transaction_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_btn.Location = new System.Drawing.Point(11, 524);
            this.transaction_btn.Name = "transaction_btn";
            this.transaction_btn.Size = new System.Drawing.Size(197, 49);
            this.transaction_btn.TabIndex = 3;
            this.transaction_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_btn.UseVisualStyleBackColor = true;
            this.transaction_btn.Click += new System.EventHandler(this.transaction_btn_Click);
            // 
            // delivery_btn
            // 
            this.delivery_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delivery_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery_btn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery_btn.Location = new System.Drawing.Point(20, 408);
            this.delivery_btn.Name = "delivery_btn";
            this.delivery_btn.Size = new System.Drawing.Size(197, 49);
            this.delivery_btn.TabIndex = 2;
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
            this.sales_btn.Text = "Create Order";
            this.sales_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales_btn.UseVisualStyleBackColor = true;
            this.sales_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControlEmployees1
            // 
            this.userControlEmployees1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlEmployees1.Location = new System.Drawing.Point(264, 0);
            this.userControlEmployees1.Name = "userControlEmployees1";
            this.userControlEmployees1.Size = new System.Drawing.Size(1648, 1050);
            this.userControlEmployees1.TabIndex = 3;
            this.userControlEmployees1.Visible = false;
            this.userControlEmployees1.Load += new System.EventHandler(this.userControlEmployees1_Load);
            // 
            // userControlSales3
            // 
            this.userControlSales3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlSales3.Location = new System.Drawing.Point(264, 0);
            this.userControlSales3.Name = "userControlSales3";
            this.userControlSales3.Size = new System.Drawing.Size(1666, 1158);
            this.userControlSales3.TabIndex = 2;
            this.userControlSales3.Load += new System.EventHandler(this.userControlSales3_Load);
            // 
            // userControlSales2
            // 
            this.userControlSales2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlSales2.Location = new System.Drawing.Point(263, 0);
            this.userControlSales2.Name = "userControlSales2";
            this.userControlSales2.Size = new System.Drawing.Size(1453, 1149);
            this.userControlSales2.TabIndex = 2;
            this.userControlSales2.Load += new System.EventHandler(this.userControlSales2_Load);
            // 
            // userControlSales1
            // 
            this.userControlSales1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlSales1.Location = new System.Drawing.Point(0, 0);
            this.userControlSales1.Name = "userControlSales1";
            this.userControlSales1.Size = new System.Drawing.Size(1453, 698);
            this.userControlSales1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.userControlEmployees1);
            this.Controls.Add(this.userControlSales3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button transaction_btn;
        private System.Windows.Forms.Button delivery_btn;
        private System.Windows.Forms.Button sales_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button employee_btn;
        private User_Control.UserControlSales userControlSales1;
        private User_Control.UserControlSales userControlSales2;
        private User_Control.UserControlSales userControlSales3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private User_Control.UserControlEmployees userControlEmployees1;
    }
}