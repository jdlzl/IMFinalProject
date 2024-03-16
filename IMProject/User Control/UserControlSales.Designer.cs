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
            this.addDelivery = new System.Windows.Forms.Button();
            this.delDelivery = new System.Windows.Forms.Button();
            this.delivery_dataGrid = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.customers_dataGrid = new System.Windows.Forms.DataGridView();
            this.transaction_details = new System.Windows.Forms.DataGridView();
            this.totalPrice = new System.Windows.Forms.Label();
            this.changeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.water_type = new System.Windows.Forms.DataGridView();
            this.initialPricetxt = new System.Windows.Forms.Label();
            this.waterTypetxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cashRadiobtn = new System.Windows.Forms.RadioButton();
            this.gcashRadiobtn = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alBtn = new System.Windows.Forms.RadioButton();
            this.purBtn = new System.Windows.Forms.RadioButton();
            this.mineralBtn = new System.Windows.Forms.RadioButton();
            this.customerIDtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tranSearchTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_type)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addDelivery);
            this.panel1.Controls.Add(this.delDelivery);
            this.panel1.Controls.Add(this.delivery_dataGrid);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(643, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 575);
            this.panel1.TabIndex = 1;
            // 
            // addDelivery
            // 
            this.addDelivery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDelivery.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDelivery.Location = new System.Drawing.Point(272, 408);
            this.addDelivery.Name = "addDelivery";
            this.addDelivery.Size = new System.Drawing.Size(153, 46);
            this.addDelivery.TabIndex = 24;
            this.addDelivery.Text = "Add Delivery";
            this.addDelivery.UseVisualStyleBackColor = false;
            this.addDelivery.Click += new System.EventHandler(this.addDelivery_Click);
            // 
            // delDelivery
            // 
            this.delDelivery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delDelivery.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDelivery.Location = new System.Drawing.Point(499, 408);
            this.delDelivery.Name = "delDelivery";
            this.delDelivery.Size = new System.Drawing.Size(164, 46);
            this.delDelivery.TabIndex = 23;
            this.delDelivery.Text = "Delete Delivery";
            this.delDelivery.UseVisualStyleBackColor = false;
            this.delDelivery.Click += new System.EventHandler(this.delDelivery_Click);
            // 
            // delivery_dataGrid
            // 
            this.delivery_dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delivery_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delivery_dataGrid.Location = new System.Drawing.Point(18, 92);
            this.delivery_dataGrid.Name = "delivery_dataGrid";
            this.delivery_dataGrid.RowHeadersWidth = 62;
            this.delivery_dataGrid.RowTemplate.Height = 28;
            this.delivery_dataGrid.Size = new System.Drawing.Size(877, 285);
            this.delivery_dataGrid.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 34);
            this.label15.TabIndex = 18;
            this.label15.Text = "Delivery";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 34);
            this.label10.TabIndex = 6;
            this.label10.Text = "Customer List";
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(361, 343);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(149, 46);
            this.delButton.TabIndex = 5;
            this.delButton.Text = "Delete Customer";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(193, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(232, 52);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(283, 26);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(22, 55);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(204, 21);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Search Customer Name: ";
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCustomer.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(23, 343);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(159, 46);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // customers_dataGrid
            // 
            this.customers_dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customers_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.customers_dataGrid.Location = new System.Drawing.Point(23, 91);
            this.customers_dataGrid.Name = "customers_dataGrid";
            this.customers_dataGrid.RowHeadersWidth = 62;
            this.customers_dataGrid.RowTemplate.Height = 28;
            this.customers_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_dataGrid.Size = new System.Drawing.Size(492, 228);
            this.customers_dataGrid.TabIndex = 0;
            this.customers_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_dataGrid_CellContentClick);
            // 
            // transaction_details
            // 
            this.transaction_details.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transaction_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_details.Location = new System.Drawing.Point(17, 106);
            this.transaction_details.Name = "transaction_details";
            this.transaction_details.RowHeadersWidth = 62;
            this.transaction_details.RowTemplate.Height = 28;
            this.transaction_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_details.Size = new System.Drawing.Size(879, 325);
            this.transaction_details.TabIndex = 16;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(88, 840);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(16, 19);
            this.totalPrice.TabIndex = 15;
            this.totalPrice.Text = "-";
            // 
            // changeText
            // 
            this.changeText.AutoSize = true;
            this.changeText.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeText.Location = new System.Drawing.Point(116, 920);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(16, 19);
            this.changeText.TabIndex = 14;
            this.changeText.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 958);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 879);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 920);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Change:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 882);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 841);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 763);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Water Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 799);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 709);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity: ";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(372, 707);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(85, 26);
            this.quantity.TabIndex = 7;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(188, 958);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(140, 45);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(353, 958);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(140, 45);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // water_type
            // 
            this.water_type.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.water_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.water_type.Location = new System.Drawing.Point(23, 466);
            this.water_type.Name = "water_type";
            this.water_type.RowHeadersWidth = 62;
            this.water_type.RowTemplate.Height = 28;
            this.water_type.Size = new System.Drawing.Size(485, 206);
            this.water_type.TabIndex = 17;
            // 
            // initialPricetxt
            // 
            this.initialPricetxt.AutoSize = true;
            this.initialPricetxt.Location = new System.Drawing.Point(88, 812);
            this.initialPricetxt.Name = "initialPricetxt";
            this.initialPricetxt.Size = new System.Drawing.Size(0, 20);
            this.initialPricetxt.TabIndex = 16;
            // 
            // waterTypetxt
            // 
            this.waterTypetxt.AutoSize = true;
            this.waterTypetxt.Location = new System.Drawing.Point(130, 763);
            this.waterTypetxt.Name = "waterTypetxt";
            this.waterTypetxt.Size = new System.Drawing.Size(0, 20);
            this.waterTypetxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Payment Method:";
            // 
            // cashRadiobtn
            // 
            this.cashRadiobtn.AutoSize = true;
            this.cashRadiobtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRadiobtn.Location = new System.Drawing.Point(11, 23);
            this.cashRadiobtn.Name = "cashRadiobtn";
            this.cashRadiobtn.Size = new System.Drawing.Size(73, 23);
            this.cashRadiobtn.TabIndex = 25;
            this.cashRadiobtn.TabStop = true;
            this.cashRadiobtn.Text = "Cash";
            this.cashRadiobtn.UseVisualStyleBackColor = true;
            // 
            // gcashRadiobtn
            // 
            this.gcashRadiobtn.AutoSize = true;
            this.gcashRadiobtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcashRadiobtn.Location = new System.Drawing.Point(11, 53);
            this.gcashRadiobtn.Name = "gcashRadiobtn";
            this.gcashRadiobtn.Size = new System.Drawing.Size(86, 23);
            this.gcashRadiobtn.TabIndex = 26;
            this.gcashRadiobtn.TabStop = true;
            this.gcashRadiobtn.Text = "GCash";
            this.gcashRadiobtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cashRadiobtn);
            this.panel3.Controls.Add(this.gcashRadiobtn);
            this.panel3.Location = new System.Drawing.Point(285, 788);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 85);
            this.panel3.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.alBtn);
            this.panel2.Controls.Add(this.purBtn);
            this.panel2.Controls.Add(this.mineralBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 57);
            this.panel2.TabIndex = 33;
            // 
            // alBtn
            // 
            this.alBtn.AutoSize = true;
            this.alBtn.Location = new System.Drawing.Point(212, 19);
            this.alBtn.Name = "alBtn";
            this.alBtn.Size = new System.Drawing.Size(43, 24);
            this.alBtn.TabIndex = 5;
            this.alBtn.TabStop = true;
            this.alBtn.Text = "3";
            this.alBtn.UseVisualStyleBackColor = true;
            this.alBtn.CheckedChanged += new System.EventHandler(this.alBtn_CheckedChanged);
            // 
            // purBtn
            // 
            this.purBtn.AutoSize = true;
            this.purBtn.Location = new System.Drawing.Point(145, 19);
            this.purBtn.Name = "purBtn";
            this.purBtn.Size = new System.Drawing.Size(43, 24);
            this.purBtn.TabIndex = 4;
            this.purBtn.TabStop = true;
            this.purBtn.Text = "2";
            this.purBtn.UseVisualStyleBackColor = true;
            this.purBtn.CheckedChanged += new System.EventHandler(this.purBtn_CheckedChanged);
            // 
            // mineralBtn
            // 
            this.mineralBtn.AutoSize = true;
            this.mineralBtn.Location = new System.Drawing.Point(81, 19);
            this.mineralBtn.Name = "mineralBtn";
            this.mineralBtn.Size = new System.Drawing.Size(43, 24);
            this.mineralBtn.TabIndex = 3;
            this.mineralBtn.TabStop = true;
            this.mineralBtn.Text = "1";
            this.mineralBtn.UseVisualStyleBackColor = true;
            this.mineralBtn.CheckedChanged += new System.EventHandler(this.mineralBtn_CheckedChanged);
            // 
            // customerIDtxt
            // 
            this.customerIDtxt.Location = new System.Drawing.Point(399, 744);
            this.customerIDtxt.Name = "customerIDtxt";
            this.customerIDtxt.Size = new System.Drawing.Size(66, 26);
            this.customerIDtxt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 749);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Customer ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tranSearchTxt);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.transaction_details);
            this.panel4.Location = new System.Drawing.Point(643, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(918, 443);
            this.panel4.TabIndex = 34;
            // 
            // tranSearchTxt
            // 
            this.tranSearchTxt.Location = new System.Drawing.Point(87, 64);
            this.tranSearchTxt.Name = "tranSearchTxt";
            this.tranSearchTxt.Size = new System.Drawing.Size(352, 26);
            this.tranSearchTxt.TabIndex = 8;
            this.tranSearchTxt.TextChanged += new System.EventHandler(this.tranSearchTxt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Search: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 34);
            this.label11.TabIndex = 7;
            this.label11.Text = "Transactions List";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 34);
            this.label13.TabIndex = 35;
            this.label13.Text = "Water Type";
            // 
            // UserControlSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customers_dataGrid);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.customerIDtxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.changeText);
            this.Controls.Add(this.totalPrice);
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
            this.Controls.Add(this.panel1);
            this.Name = "UserControlSales";
            this.Size = new System.Drawing.Size(1620, 1158);
            this.Load += new System.EventHandler(this.UserControlSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_type)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton cashRadiobtn;
        private System.Windows.Forms.RadioButton gcashRadiobtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton purBtn;
        private System.Windows.Forms.RadioButton mineralBtn;
        private System.Windows.Forms.RadioButton alBtn;
        private System.Windows.Forms.TextBox customerIDtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView customers_dataGrid;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tranSearchTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button delDelivery;
        private System.Windows.Forms.DataGridView delivery_dataGrid;
        private System.Windows.Forms.Button addDelivery;
    }
}
