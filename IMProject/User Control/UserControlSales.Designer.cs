namespace IMProject.User_Control
{
    partial class UserControlSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.transaction_details = new System.Windows.Forms.DataGridView();
            this.totalPrice = new System.Windows.Forms.Label();
            this.changeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.water_type = new System.Windows.Forms.DataGridView();
            this.initialPricetxt = new System.Windows.Forms.Label();
            this.waterTypetxt = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.customerIDtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cashRadiobtn = new System.Windows.Forms.RadioButton();
            this.gcashRadiobtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_type)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transaction_details);
            this.panel1.Controls.Add(this.totalPrice);
            this.panel1.Controls.Add(this.changeText);
            this.panel1.Location = new System.Drawing.Point(534, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 695);
            this.panel1.TabIndex = 1;
            // 
            // transaction_details
            // 
            this.transaction_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_details.Location = new System.Drawing.Point(19, 12);
            this.transaction_details.Name = "transaction_details";
            this.transaction_details.RowHeadersWidth = 62;
            this.transaction_details.RowTemplate.Height = 28;
            this.transaction_details.Size = new System.Drawing.Size(1285, 656);
            this.transaction_details.TabIndex = 16;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(219, 385);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(0, 20);
            this.totalPrice.TabIndex = 15;
            // 
            // changeText
            // 
            this.changeText.AutoSize = true;
            this.changeText.Location = new System.Drawing.Point(219, 473);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(0, 20);
            this.changeText.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Change:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Water Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity: ";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(355, 388);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(85, 26);
            this.quantity.TabIndex = 7;
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(190, 626);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(140, 45);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(355, 626);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(140, 45);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // water_type
            // 
            this.water_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.water_type.Location = new System.Drawing.Point(25, 15);
            this.water_type.Name = "water_type";
            this.water_type.RowHeadersWidth = 62;
            this.water_type.RowTemplate.Height = 28;
            this.water_type.Size = new System.Drawing.Size(485, 295);
            this.water_type.TabIndex = 17;
            // 
            // initialPricetxt
            // 
            this.initialPricetxt.AutoSize = true;
            this.initialPricetxt.Location = new System.Drawing.Point(90, 439);
            this.initialPricetxt.Name = "initialPricetxt";
            this.initialPricetxt.Size = new System.Drawing.Size(0, 20);
            this.initialPricetxt.TabIndex = 16;
            // 
            // waterTypetxt
            // 
            this.waterTypetxt.AutoSize = true;
            this.waterTypetxt.Location = new System.Drawing.Point(132, 390);
            this.waterTypetxt.Name = "waterTypetxt";
            this.waterTypetxt.Size = new System.Drawing.Size(0, 20);
            this.waterTypetxt.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(106, 336);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 24);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 336);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 24);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(229, 337);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 24);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Customer ID:";
            // 
            // customerIDtxt
            // 
            this.customerIDtxt.Location = new System.Drawing.Point(382, 439);
            this.customerIDtxt.Name = "customerIDtxt";
            this.customerIDtxt.Size = new System.Drawing.Size(128, 26);
            this.customerIDtxt.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Payment Method:";
            // 
            // cashRadiobtn
            // 
            this.cashRadiobtn.AutoSize = true;
            this.cashRadiobtn.Location = new System.Drawing.Point(277, 518);
            this.cashRadiobtn.Name = "cashRadiobtn";
            this.cashRadiobtn.Size = new System.Drawing.Size(71, 24);
            this.cashRadiobtn.TabIndex = 25;
            this.cashRadiobtn.TabStop = true;
            this.cashRadiobtn.Text = "Cash";
            this.cashRadiobtn.UseVisualStyleBackColor = true;
            // 
            // gcashRadiobtn
            // 
            this.gcashRadiobtn.AutoSize = true;
            this.gcashRadiobtn.Location = new System.Drawing.Point(277, 548);
            this.gcashRadiobtn.Name = "gcashRadiobtn";
            this.gcashRadiobtn.Size = new System.Drawing.Size(84, 24);
            this.gcashRadiobtn.TabIndex = 26;
            this.gcashRadiobtn.TabStop = true;
            this.gcashRadiobtn.Text = "GCash";
            this.gcashRadiobtn.UseVisualStyleBackColor = true;
            // 
            // UserControlSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcashRadiobtn);
            this.Controls.Add(this.cashRadiobtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customerIDtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.waterTypetxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.initialPricetxt);
            this.Controls.Add(this.water_type);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlSales";
            this.Size = new System.Drawing.Size(1902, 698);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label changeText;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView water_type;
        private System.Windows.Forms.Label initialPricetxt;
        private System.Windows.Forms.Label waterTypetxt;
        private System.Windows.Forms.DataGridView transaction_details;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerIDtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton cashRadiobtn;
        private System.Windows.Forms.RadioButton gcashRadiobtn;
    }
}
