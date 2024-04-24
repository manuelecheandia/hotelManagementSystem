namespace hotelaubergehotel.WinFrontEnd
{
    partial class frmViewReservation
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
            grpSearchReservation = new GroupBox();
            txtEmailAddress = new TextBox();
            txtRoomNumber = new TextBox();
            txtLastName = new TextBox();
            txtConfrimationNumber = new TextBox();
            dtpCheckInDate = new DateTimePicker();
            dtpDateCreated = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnFindReservation = new Button();
            groupBox1 = new GroupBox();
            dgvReservations = new DataGridView();
            grpSearchReservation.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // grpSearchReservation
            // 
            grpSearchReservation.Controls.Add(txtEmailAddress);
            grpSearchReservation.Controls.Add(txtRoomNumber);
            grpSearchReservation.Controls.Add(txtLastName);
            grpSearchReservation.Controls.Add(txtConfrimationNumber);
            grpSearchReservation.Controls.Add(dtpCheckInDate);
            grpSearchReservation.Controls.Add(dtpDateCreated);
            grpSearchReservation.Controls.Add(label3);
            grpSearchReservation.Controls.Add(label2);
            grpSearchReservation.Controls.Add(label6);
            grpSearchReservation.Controls.Add(label5);
            grpSearchReservation.Controls.Add(label4);
            grpSearchReservation.Controls.Add(label1);
            grpSearchReservation.Controls.Add(btnFindReservation);
            grpSearchReservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpSearchReservation.Location = new Point(19, 32);
            grpSearchReservation.Name = "grpSearchReservation";
            grpSearchReservation.Size = new Size(936, 170);
            grpSearchReservation.TabIndex = 1;
            grpSearchReservation.TabStop = false;
            grpSearchReservation.Text = "Search Reservation";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(462, 118);
            txtEmailAddress.Margin = new Padding(3, 2, 3, 2);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(193, 23);
            txtEmailAddress.TabIndex = 5;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(462, 88);
            txtRoomNumber.Margin = new Padding(3, 2, 3, 2);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(193, 23);
            txtRoomNumber.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(141, 124);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtConfrimationNumber
            // 
            txtConfrimationNumber.Location = new Point(141, 82);
            txtConfrimationNumber.Margin = new Padding(3, 2, 3, 2);
            txtConfrimationNumber.Name = "txtConfrimationNumber";
            txtConfrimationNumber.Size = new Size(192, 23);
            txtConfrimationNumber.TabIndex = 3;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCheckInDate.Location = new Point(462, 42);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(195, 23);
            dtpCheckInDate.TabIndex = 2;
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateCreated.Location = new Point(141, 38);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(194, 23);
            dtpDateCreated.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Confrimation #:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(385, 121);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(385, 88);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 6;
            label5.Text = "Room #:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(382, 46);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Check in:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Date Created:";
            // 
            // btnFindReservation
            // 
            btnFindReservation.BackColor = Color.FromArgb(25, 118, 210);
            btnFindReservation.ForeColor = SystemColors.Control;
            btnFindReservation.Location = new Point(710, 42);
            btnFindReservation.Name = "btnFindReservation";
            btnFindReservation.Size = new Size(172, 99);
            btnFindReservation.TabIndex = 6;
            btnFindReservation.Text = "Find Reservation";
            btnFindReservation.UseVisualStyleBackColor = false;
            btnFindReservation.Click += btnFindReservation_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvReservations);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 256);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservations";
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(20, 28);
            dgvReservations.Margin = new Padding(3, 2, 3, 2);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.RowTemplate.Height = 29;
            dgvReservations.Size = new Size(889, 212);
            dgvReservations.TabIndex = 8;
            // 
            // frmViewReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 474);
            Controls.Add(groupBox1);
            Controls.Add(grpSearchReservation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmViewReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmViewReservation";
            grpSearchReservation.ResumeLayout(false);
            grpSearchReservation.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSearchReservation;
        private Button btnFindReservation;
        private GroupBox groupBox1;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpDateCreated;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtEmailAddress;
        private TextBox txtRoomNumber;
        private TextBox txtLastName;
        private TextBox txtConfrimationNumber;
        private DataGridView dgvReservations;
    }
}