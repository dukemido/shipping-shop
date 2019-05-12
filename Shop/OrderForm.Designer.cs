namespace Shop
{
    partial class OrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderNo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShippingAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderGroup = new System.Windows.Forms.GroupBox();
            this.Paid = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ManualPrice = new System.Windows.Forms.CheckBox();
            this.AvailableQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FinalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ControlsGroup = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.OrderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.ControlsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.orderNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ShippingAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CusName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // orderNo
            // 
            this.orderNo.AutoSize = true;
            this.orderNo.ForeColor = System.Drawing.Color.Blue;
            this.orderNo.Location = new System.Drawing.Point(364, 73);
            this.orderNo.Name = "orderNo";
            this.orderNo.Size = new System.Drawing.Size(10, 13);
            this.orderNo.TabIndex = 5;
            this.orderNo.Text = ".";
            this.orderNo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(309, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Order No:";
            this.label8.Visible = false;
            // 
            // ShippingAddress
            // 
            this.ShippingAddress.AutoSize = true;
            this.ShippingAddress.Location = new System.Drawing.Point(367, 26);
            this.ShippingAddress.Name = "ShippingAddress";
            this.ShippingAddress.Size = new System.Drawing.Size(10, 13);
            this.ShippingAddress.TabIndex = 3;
            this.ShippingAddress.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipping Address: ";
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(90, 26);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(10, 13);
            this.CusName.TabIndex = 1;
            this.CusName.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name: ";
            // 
            // OrderGroup
            // 
            this.OrderGroup.Controls.Add(this.Paid);
            this.OrderGroup.Controls.Add(this.label6);
            this.OrderGroup.Controls.Add(this.ManualPrice);
            this.OrderGroup.Controls.Add(this.AvailableQuantity);
            this.OrderGroup.Controls.Add(this.label5);
            this.OrderGroup.Controls.Add(this.label4);
            this.OrderGroup.Controls.Add(this.numericUpDown1);
            this.OrderGroup.Controls.Add(this.FinalPrice);
            this.OrderGroup.Controls.Add(this.label2);
            this.OrderGroup.Controls.Add(this.comboBox1);
            this.OrderGroup.Location = new System.Drawing.Point(12, 124);
            this.OrderGroup.Name = "OrderGroup";
            this.OrderGroup.Size = new System.Drawing.Size(628, 128);
            this.OrderGroup.TabIndex = 1;
            this.OrderGroup.TabStop = false;
            this.OrderGroup.Text = "Order Information";
            // 
            // Paid
            // 
            this.Paid.AutoSize = true;
            this.Paid.Location = new System.Drawing.Point(93, 99);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(47, 17);
            this.Paid.TabIndex = 13;
            this.Paid.Text = "Paid";
            this.Paid.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price:";
            // 
            // ManualPrice
            // 
            this.ManualPrice.AutoSize = true;
            this.ManualPrice.Enabled = false;
            this.ManualPrice.Location = new System.Drawing.Point(373, 75);
            this.ManualPrice.Name = "ManualPrice";
            this.ManualPrice.Size = new System.Drawing.Size(94, 17);
            this.ManualPrice.TabIndex = 11;
            this.ManualPrice.Text = "Access Price?";
            this.ManualPrice.UseVisualStyleBackColor = true;
            this.ManualPrice.CheckedChanged += new System.EventHandler(this.ManualPrice_CheckedChanged);
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.AutoSize = true;
            this.AvailableQuantity.Location = new System.Drawing.Point(448, 47);
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.Size = new System.Drawing.Size(10, 13);
            this.AvailableQuantity.TabIndex = 10;
            this.AvailableQuantity.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Available: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(93, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(269, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FinalPrice
            // 
            this.FinalPrice.Enabled = false;
            this.FinalPrice.Location = new System.Drawing.Point(93, 73);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(269, 20);
            this.FinalPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(529, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ControlsGroup
            // 
            this.ControlsGroup.Controls.Add(this.button2);
            this.ControlsGroup.Controls.Add(this.button1);
            this.ControlsGroup.Location = new System.Drawing.Point(12, 258);
            this.ControlsGroup.Name = "ControlsGroup";
            this.ControlsGroup.Size = new System.Drawing.Size(628, 100);
            this.ControlsGroup.TabIndex = 2;
            this.ControlsGroup.TabStop = false;
            this.ControlsGroup.Text = "Controls";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(616, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(616, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.ForeColor = System.Drawing.Color.Blue;
            this.DateLabel.Location = new System.Drawing.Point(90, 73);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(10, 13);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = ".";
            this.DateLabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(22, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Order Date:";
            this.label9.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 373);
            this.Controls.Add(this.ControlsGroup);
            this.Controls.Add(this.OrderGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OrderGroup.ResumeLayout(false);
            this.OrderGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ControlsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ShippingAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox OrderGroup;
        private System.Windows.Forms.CheckBox ManualPrice;
        private System.Windows.Forms.Label AvailableQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox FinalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox Paid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label orderNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox ControlsGroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label9;
    }
}