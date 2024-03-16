namespace IMProject.User_Control
{
    partial class UserControlEmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employee_gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_gridView
            // 
            this.employee_gridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employee_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_gridView.Location = new System.Drawing.Point(35, 75);
            this.employee_gridView.Name = "employee_gridView";
            this.employee_gridView.RowHeadersWidth = 62;
            this.employee_gridView.RowTemplate.Height = 28;
            this.employee_gridView.Size = new System.Drawing.Size(780, 223);
            this.employee_gridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List:";
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(559, 332);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(161, 46);
            this.delButton.TabIndex = 8;
            this.delButton.Text = "Delete Customer";
            this.delButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(331, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit Customer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCustomer.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(111, 332);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(168, 46);
            this.addCustomer.TabIndex = 6;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            // 
            // UserControlEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_gridView);
            this.Name = "UserControlEmployees";
            this.Size = new System.Drawing.Size(915, 445);
            ((System.ComponentModel.ISupportInitialize)(this.employee_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_gridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addCustomer;
    }
}
