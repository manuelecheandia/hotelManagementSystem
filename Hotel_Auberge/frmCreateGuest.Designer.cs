namespace hotelaubergehotel.WinFrontEnd
{
    partial class frmCreateGuest
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
            txtGuestId = new GroupBox();
            cboProvince = new ComboBox();
            cboCountry = new ComboBox();
            label20 = new Label();
            label5 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            txtGuestEmailAddress = new TextBox();
            txtGuestSecondaryPhoneNumber = new TextBox();
            label16 = new Label();
            txtGuestPrimaryPhoneNumber = new TextBox();
            label15 = new Label();
            txtGuestPostalCode = new TextBox();
            label14 = new Label();
            txtGuestMunicipality = new TextBox();
            label13 = new Label();
            txtGuestStreetAddress = new TextBox();
            label12 = new Label();
            txtGuestLastName = new TextBox();
            label11 = new Label();
            txtGuestMiddleName = new TextBox();
            label1 = new Label();
            txtGuestFirstName = new TextBox();
            btnCreateGuest = new Button();
            txtGuestId.SuspendLayout();
            SuspendLayout();
            // 
            // txtGuestId
            // 
            txtGuestId.Controls.Add(cboProvince);
            txtGuestId.Controls.Add(cboCountry);
            txtGuestId.Controls.Add(label20);
            txtGuestId.Controls.Add(label5);
            txtGuestId.Controls.Add(dtpDateOfBirth);
            txtGuestId.Controls.Add(label19);
            txtGuestId.Controls.Add(label18);
            txtGuestId.Controls.Add(label17);
            txtGuestId.Controls.Add(txtGuestEmailAddress);
            txtGuestId.Controls.Add(txtGuestSecondaryPhoneNumber);
            txtGuestId.Controls.Add(label16);
            txtGuestId.Controls.Add(txtGuestPrimaryPhoneNumber);
            txtGuestId.Controls.Add(label15);
            txtGuestId.Controls.Add(txtGuestPostalCode);
            txtGuestId.Controls.Add(label14);
            txtGuestId.Controls.Add(txtGuestMunicipality);
            txtGuestId.Controls.Add(label13);
            txtGuestId.Controls.Add(txtGuestStreetAddress);
            txtGuestId.Controls.Add(label12);
            txtGuestId.Controls.Add(txtGuestLastName);
            txtGuestId.Controls.Add(label11);
            txtGuestId.Controls.Add(txtGuestMiddleName);
            txtGuestId.Controls.Add(label1);
            txtGuestId.Controls.Add(txtGuestFirstName);
            txtGuestId.Location = new Point(25, 21);
            txtGuestId.Name = "txtGuestId";
            txtGuestId.Size = new Size(635, 523);
            txtGuestId.TabIndex = 10;
            txtGuestId.TabStop = false;
            txtGuestId.Text = "Guest Stay Information";
            // 
            // cboProvince
            // 
            cboProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(196, 457);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(251, 28);
            cboProvince.TabIndex = 12;
            // 
            // cboCountry
            // 
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(195, 410);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(251, 28);
            cboCountry.TabIndex = 11;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label20.Location = new Point(18, 413);
            label20.Name = "label20";
            label20.Size = new Size(63, 20);
            label20.TabIndex = 9;
            label20.Text = "Country:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(18, 457);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Province:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(196, 155);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label19.Location = new Point(19, 160);
            label19.Name = "label19";
            label19.Size = new Size(97, 20);
            label19.TabIndex = 5;
            label19.Text = "Date Of Birth:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label18.Location = new Point(18, 365);
            label18.Name = "label18";
            label18.Size = new Size(101, 20);
            label18.TabIndex = 5;
            label18.Text = "Email Address:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(19, 332);
            label17.Name = "label17";
            label17.Size = new Size(157, 20);
            label17.TabIndex = 5;
            label17.Text = "Second Phone Number:";
            // 
            // txtGuestEmailAddress
            // 
            txtGuestEmailAddress.Location = new Point(196, 365);
            txtGuestEmailAddress.Name = "txtGuestEmailAddress";
            txtGuestEmailAddress.Size = new Size(250, 27);
            txtGuestEmailAddress.TabIndex = 10;
            // 
            // txtGuestSecondaryPhoneNumber
            // 
            txtGuestSecondaryPhoneNumber.Location = new Point(197, 329);
            txtGuestSecondaryPhoneNumber.Name = "txtGuestSecondaryPhoneNumber";
            txtGuestSecondaryPhoneNumber.Size = new Size(250, 27);
            txtGuestSecondaryPhoneNumber.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(19, 293);
            label16.Name = "label16";
            label16.Size = new Size(108, 20);
            label16.TabIndex = 5;
            label16.Text = "Phone Number:";
            // 
            // txtGuestPrimaryPhoneNumber
            // 
            txtGuestPrimaryPhoneNumber.Location = new Point(196, 293);
            txtGuestPrimaryPhoneNumber.Name = "txtGuestPrimaryPhoneNumber";
            txtGuestPrimaryPhoneNumber.Size = new Size(250, 27);
            txtGuestPrimaryPhoneNumber.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(19, 260);
            label15.Name = "label15";
            label15.Size = new Size(89, 20);
            label15.TabIndex = 5;
            label15.Text = "Postal Code:";
            // 
            // txtGuestPostalCode
            // 
            txtGuestPostalCode.Location = new Point(196, 259);
            txtGuestPostalCode.Name = "txtGuestPostalCode";
            txtGuestPostalCode.Size = new Size(250, 27);
            txtGuestPostalCode.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(19, 226);
            label14.Name = "label14";
            label14.Size = new Size(91, 20);
            label14.TabIndex = 5;
            label14.Text = "Municipality:";
            // 
            // txtGuestMunicipality
            // 
            txtGuestMunicipality.Location = new Point(196, 226);
            txtGuestMunicipality.Name = "txtGuestMunicipality";
            txtGuestMunicipality.Size = new Size(250, 27);
            txtGuestMunicipality.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(19, 193);
            label13.Name = "label13";
            label13.Size = new Size(101, 20);
            label13.TabIndex = 5;
            label13.Text = "Street Address:";
            // 
            // txtGuestStreetAddress
            // 
            txtGuestStreetAddress.Location = new Point(196, 193);
            txtGuestStreetAddress.Name = "txtGuestStreetAddress";
            txtGuestStreetAddress.Size = new Size(250, 27);
            txtGuestStreetAddress.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(18, 120);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 5;
            label12.Text = "Last Name:";
            // 
            // txtGuestLastName
            // 
            txtGuestLastName.Location = new Point(195, 120);
            txtGuestLastName.Name = "txtGuestLastName";
            txtGuestLastName.Size = new Size(251, 27);
            txtGuestLastName.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(18, 87);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 5;
            label11.Text = "Middle Name:";
            // 
            // txtGuestMiddleName
            // 
            txtGuestMiddleName.Location = new Point(195, 87);
            txtGuestMiddleName.Name = "txtGuestMiddleName";
            txtGuestMiddleName.Size = new Size(251, 27);
            txtGuestMiddleName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "First Name:";
            // 
            // txtGuestFirstName
            // 
            txtGuestFirstName.Location = new Point(195, 46);
            txtGuestFirstName.Name = "txtGuestFirstName";
            txtGuestFirstName.Size = new Size(251, 27);
            txtGuestFirstName.TabIndex = 1;
            // 
            // btnCreateGuest
            // 
            btnCreateGuest.BackColor = Color.FromArgb(25, 118, 210);
            btnCreateGuest.ForeColor = SystemColors.Control;
            btnCreateGuest.Location = new Point(108, 551);
            btnCreateGuest.Margin = new Padding(3, 4, 3, 4);
            btnCreateGuest.Name = "btnCreateGuest";
            btnCreateGuest.Size = new Size(418, 53);
            btnCreateGuest.TabIndex = 13;
            btnCreateGuest.Text = "Create Guest ";
            btnCreateGuest.UseVisualStyleBackColor = false;
            btnCreateGuest.Click += btnCreateGuest_Click;
            // 
            // frmCreateGuest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 617);
            Controls.Add(btnCreateGuest);
            Controls.Add(txtGuestId);
            Name = "frmCreateGuest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCreateGuest";
            Load += frmCreateGuest_Load;
            txtGuestId.ResumeLayout(false);
            txtGuestId.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox txtGuestId;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox txtGuestEmailAddress;
        private TextBox txtGuestSecondaryPhoneNumber;
        private Label label16;
        private TextBox txtGuestPrimaryPhoneNumber;
        private Label label15;
        private TextBox txtGuestPostalCode;
        private Label label14;
        private TextBox txtGuestMunicipality;
        private Label label13;
        private TextBox txtGuestStreetAddress;
        private Label label12;
        private TextBox txtGuestLastName;
        private Label label11;
        private TextBox txtGuestMiddleName;
        private Label label1;
        private TextBox txtGuestFirstName;
        private Button btnCreateGuest;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cboProvince;
        private ComboBox cboCountry;
        private Label label20;
        private Label label5;
    }
}