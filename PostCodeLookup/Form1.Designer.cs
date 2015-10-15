namespace PostCodeLookup
{
    partial class Form1
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasicLookup = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtBasicPC = new System.Windows.Forms.TextBox();
            this.txtBasicCounty = new System.Windows.Forms.TextBox();
            this.txtBasicCity = new System.Windows.Forms.TextBox();
            this.txtBasicAL2 = new System.Windows.Forms.TextBox();
            this.txtBasicAL1 = new System.Windows.Forms.TextBox();
            this.txtBasicHouseNo = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtBasicPostCode = new System.Windows.Forms.TextBox();
            this.btnGetAddress = new System.Windows.Forms.Button();
            this.tabRapidAddress = new System.Windows.Forms.TabPage();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.cboAddressList = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtRapidPC = new System.Windows.Forms.TextBox();
            this.txtRapidCounty = new System.Windows.Forms.TextBox();
            this.txtRapidCity = new System.Windows.Forms.TextBox();
            this.txtRapidAL2 = new System.Windows.Forms.TextBox();
            this.txtRapidAL1 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtRapidPostCode = new System.Windows.Forms.TextBox();
            this.btnRapidGetAddresses = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabBasicLookup.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tabRapidAddress.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabBasicLookup);
            this.TabControl1.Controls.Add(this.tabRapidAddress);
            this.TabControl1.Location = new System.Drawing.Point(12, 13);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(299, 381);
            this.TabControl1.TabIndex = 1;
            // 
            // tabBasicLookup
            // 
            this.tabBasicLookup.Controls.Add(this.GroupBox2);
            this.tabBasicLookup.Controls.Add(this.GroupBox1);
            this.tabBasicLookup.Location = new System.Drawing.Point(4, 25);
            this.tabBasicLookup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBasicLookup.Name = "tabBasicLookup";
            this.tabBasicLookup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBasicLookup.Size = new System.Drawing.Size(291, 352);
            this.tabBasicLookup.TabIndex = 0;
            this.tabBasicLookup.Text = "Basic Address";
            this.tabBasicLookup.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtBasicPC);
            this.GroupBox2.Controls.Add(this.txtBasicCounty);
            this.GroupBox2.Controls.Add(this.txtBasicCity);
            this.GroupBox2.Controls.Add(this.txtBasicAL2);
            this.GroupBox2.Controls.Add(this.txtBasicAL1);
            this.GroupBox2.Controls.Add(this.txtBasicHouseNo);
            this.GroupBox2.Location = new System.Drawing.Point(7, 107);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(268, 236);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Output";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.Red;
            this.Label8.Location = new System.Drawing.Point(8, 21);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(248, 17);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "* House No needs entering manually *";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(36, 203);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 17);
            this.Label7.TabIndex = 18;
            this.Label7.Text = "Post Code:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(57, 171);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(56, 17);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "County:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(36, 139);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(73, 17);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "City/Town:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 107);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(107, 17);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Address Line 2:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 75);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 17);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Address Line 1:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(37, 43);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 17);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "House No:";
            // 
            // txtBasicPC
            // 
            this.txtBasicPC.Location = new System.Drawing.Point(116, 199);
            this.txtBasicPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicPC.Name = "txtBasicPC";
            this.txtBasicPC.Size = new System.Drawing.Size(124, 22);
            this.txtBasicPC.TabIndex = 12;
            // 
            // txtBasicCounty
            // 
            this.txtBasicCounty.Location = new System.Drawing.Point(116, 167);
            this.txtBasicCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicCounty.Name = "txtBasicCounty";
            this.txtBasicCounty.Size = new System.Drawing.Size(124, 22);
            this.txtBasicCounty.TabIndex = 11;
            // 
            // txtBasicCity
            // 
            this.txtBasicCity.Location = new System.Drawing.Point(116, 135);
            this.txtBasicCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicCity.Name = "txtBasicCity";
            this.txtBasicCity.Size = new System.Drawing.Size(124, 22);
            this.txtBasicCity.TabIndex = 10;
            // 
            // txtBasicAL2
            // 
            this.txtBasicAL2.Location = new System.Drawing.Point(116, 103);
            this.txtBasicAL2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicAL2.Name = "txtBasicAL2";
            this.txtBasicAL2.Size = new System.Drawing.Size(124, 22);
            this.txtBasicAL2.TabIndex = 9;
            // 
            // txtBasicAL1
            // 
            this.txtBasicAL1.Location = new System.Drawing.Point(116, 71);
            this.txtBasicAL1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicAL1.Name = "txtBasicAL1";
            this.txtBasicAL1.Size = new System.Drawing.Size(124, 22);
            this.txtBasicAL1.TabIndex = 8;
            // 
            // txtBasicHouseNo
            // 
            this.txtBasicHouseNo.Location = new System.Drawing.Point(116, 39);
            this.txtBasicHouseNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicHouseNo.Name = "txtBasicHouseNo";
            this.txtBasicHouseNo.Size = new System.Drawing.Size(124, 22);
            this.txtBasicHouseNo.TabIndex = 7;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtBasicPostCode);
            this.GroupBox1.Controls.Add(this.btnGetAddress);
            this.GroupBox1.Location = new System.Drawing.Point(7, 9);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(268, 91);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Post Code Entry && Search";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(27, 28);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 17);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Post Code:";
            // 
            // txtBasicPostCode
            // 
            this.txtBasicPostCode.Location = new System.Drawing.Point(113, 23);
            this.txtBasicPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasicPostCode.Name = "txtBasicPostCode";
            this.txtBasicPostCode.Size = new System.Drawing.Size(124, 22);
            this.txtBasicPostCode.TabIndex = 6;
            this.txtBasicPostCode.Text = "AA11AB";
            // 
            // btnGetAddress
            // 
            this.btnGetAddress.Location = new System.Drawing.Point(31, 55);
            this.btnGetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAddress.Name = "btnGetAddress";
            this.btnGetAddress.Size = new System.Drawing.Size(208, 25);
            this.btnGetAddress.TabIndex = 4;
            this.btnGetAddress.Text = "Get Sample Address";
            this.btnGetAddress.UseVisualStyleBackColor = true;
            this.btnGetAddress.Click += new System.EventHandler(this.btnGetAddress_Click);
            // 
            // tabRapidAddress
            // 
            this.tabRapidAddress.Controls.Add(this.GroupBox4);
            this.tabRapidAddress.Controls.Add(this.GroupBox3);
            this.tabRapidAddress.Location = new System.Drawing.Point(4, 25);
            this.tabRapidAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRapidAddress.Name = "tabRapidAddress";
            this.tabRapidAddress.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRapidAddress.Size = new System.Drawing.Size(291, 352);
            this.tabRapidAddress.TabIndex = 1;
            this.tabRapidAddress.Text = "Rapid Address";
            this.tabRapidAddress.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label10);
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Controls.Add(this.cboAddressList);
            this.GroupBox4.Controls.Add(this.Label12);
            this.GroupBox4.Controls.Add(this.Label13);
            this.GroupBox4.Controls.Add(this.Label14);
            this.GroupBox4.Controls.Add(this.Label15);
            this.GroupBox4.Controls.Add(this.txtRapidPC);
            this.GroupBox4.Controls.Add(this.txtRapidCounty);
            this.GroupBox4.Controls.Add(this.txtRapidCity);
            this.GroupBox4.Controls.Add(this.txtRapidAL2);
            this.GroupBox4.Controls.Add(this.txtRapidAL1);
            this.GroupBox4.Location = new System.Drawing.Point(7, 106);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Size = new System.Drawing.Size(268, 236);
            this.GroupBox4.TabIndex = 9;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Output";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(8, 20);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(122, 17);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Select an address";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(36, 203);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(77, 17);
            this.Label11.TabIndex = 18;
            this.Label11.Text = "Post Code:";
            // 
            // cboAddressList
            // 
            this.cboAddressList.FormattingEnabled = true;
            this.cboAddressList.Location = new System.Drawing.Point(12, 38);
            this.cboAddressList.Margin = new System.Windows.Forms.Padding(4);
            this.cboAddressList.Name = "cboAddressList";
            this.cboAddressList.Size = new System.Drawing.Size(228, 24);
            this.cboAddressList.TabIndex = 6;
            this.cboAddressList.SelectedIndexChanged += new System.EventHandler(this.cboAddressList_SelectedIndexChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(57, 171);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(56, 17);
            this.Label12.TabIndex = 17;
            this.Label12.Text = "County:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(36, 139);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(73, 17);
            this.Label13.TabIndex = 16;
            this.Label13.Text = "City/Town:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(8, 107);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(107, 17);
            this.Label14.TabIndex = 15;
            this.Label14.Text = "Address Line 2:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(8, 75);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(107, 17);
            this.Label15.TabIndex = 14;
            this.Label15.Text = "Address Line 1:";
            // 
            // txtRapidPC
            // 
            this.txtRapidPC.Location = new System.Drawing.Point(116, 199);
            this.txtRapidPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRapidPC.Name = "txtRapidPC";
            this.txtRapidPC.Size = new System.Drawing.Size(124, 22);
            this.txtRapidPC.TabIndex = 12;
            // 
            // txtRapidCounty
            // 
            this.txtRapidCounty.Location = new System.Drawing.Point(116, 167);
            this.txtRapidCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtRapidCounty.Name = "txtRapidCounty";
            this.txtRapidCounty.Size = new System.Drawing.Size(124, 22);
            this.txtRapidCounty.TabIndex = 11;
            // 
            // txtRapidCity
            // 
            this.txtRapidCity.Location = new System.Drawing.Point(116, 135);
            this.txtRapidCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtRapidCity.Name = "txtRapidCity";
            this.txtRapidCity.Size = new System.Drawing.Size(124, 22);
            this.txtRapidCity.TabIndex = 10;
            // 
            // txtRapidAL2
            // 
            this.txtRapidAL2.Location = new System.Drawing.Point(116, 103);
            this.txtRapidAL2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRapidAL2.Name = "txtRapidAL2";
            this.txtRapidAL2.Size = new System.Drawing.Size(124, 22);
            this.txtRapidAL2.TabIndex = 9;
            // 
            // txtRapidAL1
            // 
            this.txtRapidAL1.Location = new System.Drawing.Point(116, 71);
            this.txtRapidAL1.Margin = new System.Windows.Forms.Padding(4);
            this.txtRapidAL1.Name = "txtRapidAL1";
            this.txtRapidAL1.Size = new System.Drawing.Size(124, 22);
            this.txtRapidAL1.TabIndex = 8;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.txtRapidPostCode);
            this.GroupBox3.Controls.Add(this.btnRapidGetAddresses);
            this.GroupBox3.Location = new System.Drawing.Point(7, 7);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(268, 91);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Post Code Entry && Search";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(27, 28);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(77, 17);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Post Code:";
            // 
            // txtRapidPostCode
            // 
            this.txtRapidPostCode.Location = new System.Drawing.Point(113, 23);
            this.txtRapidPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtRapidPostCode.Name = "txtRapidPostCode";
            this.txtRapidPostCode.Size = new System.Drawing.Size(124, 22);
            this.txtRapidPostCode.TabIndex = 6;
            this.txtRapidPostCode.Text = "AA11AB";
            // 
            // btnRapidGetAddresses
            // 
            this.btnRapidGetAddresses.Location = new System.Drawing.Point(31, 55);
            this.btnRapidGetAddresses.Margin = new System.Windows.Forms.Padding(4);
            this.btnRapidGetAddresses.Name = "btnRapidGetAddresses";
            this.btnRapidGetAddresses.Size = new System.Drawing.Size(208, 25);
            this.btnRapidGetAddresses.TabIndex = 4;
            this.btnRapidGetAddresses.Text = "Get Sample Address";
            this.btnRapidGetAddresses.UseVisualStyleBackColor = true;
            this.btnRapidGetAddresses.Click += new System.EventHandler(this.btnRapidGetAddresses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 412);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Crafty Clicks - Example Post Code Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabBasicLookup.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabRapidAddress.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tabBasicLookup;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtBasicPC;
        internal System.Windows.Forms.TextBox txtBasicCounty;
        internal System.Windows.Forms.TextBox txtBasicCity;
        internal System.Windows.Forms.TextBox txtBasicAL2;
        internal System.Windows.Forms.TextBox txtBasicAL1;
        internal System.Windows.Forms.TextBox txtBasicHouseNo;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtBasicPostCode;
        internal System.Windows.Forms.Button btnGetAddress;
        internal System.Windows.Forms.TabPage tabRapidAddress;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox cboAddressList;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtRapidPC;
        internal System.Windows.Forms.TextBox txtRapidCounty;
        internal System.Windows.Forms.TextBox txtRapidCity;
        internal System.Windows.Forms.TextBox txtRapidAL2;
        internal System.Windows.Forms.TextBox txtRapidAL1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtRapidPostCode;
        internal System.Windows.Forms.Button btnRapidGetAddresses;
    }
}

