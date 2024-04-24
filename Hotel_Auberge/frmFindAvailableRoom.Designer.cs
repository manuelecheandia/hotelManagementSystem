namespace Hotel_Auberge
{
    partial class frmFindAvailableRoom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpFindAvailableRoom = new GroupBox();
            btnFindRooms = new Button();
            grpGuests = new GroupBox();
            nudNumberOfChildren = new NumericUpDown();
            nudNumberOfAdults = new NumericUpDown();
            lblNumberOfChildren = new Label();
            lblNumberOfAdults = new Label();
            grpDates = new GroupBox();
            dtpCheckOutDate = new DateTimePicker();
            lblCheckOutDate = new Label();
            dtpCheckInDate = new DateTimePicker();
            label1 = new Label();
            lblAvailableRooms = new Label();
            dgvAvailableRooms = new DataGridView();
            grpGuestInfo = new GroupBox();
            grpFullNameDOB = new GroupBox();
            dtpDOB = new DateTimePicker();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnFindGuest = new Button();
            txtEmailAddress = new TextBox();
            lblEmail = new Label();
            btnCreateReservation = new Button();
            grpFindAvailableRoom.SuspendLayout();
            grpGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfAdults).BeginInit();
            grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).BeginInit();
            grpGuestInfo.SuspendLayout();
            grpFullNameDOB.SuspendLayout();
            SuspendLayout();
            // 
            // grpFindAvailableRoom
            // 
            grpFindAvailableRoom.Controls.Add(btnFindRooms);
            grpFindAvailableRoom.Controls.Add(grpGuests);
            grpFindAvailableRoom.Controls.Add(grpDates);
            grpFindAvailableRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpFindAvailableRoom.Location = new Point(64, 23);
            grpFindAvailableRoom.Margin = new Padding(3, 4, 3, 4);
            grpFindAvailableRoom.Name = "grpFindAvailableRoom";
            grpFindAvailableRoom.Padding = new Padding(3, 4, 3, 4);
            grpFindAvailableRoom.Size = new Size(913, 229);
            grpFindAvailableRoom.TabIndex = 0;
            grpFindAvailableRoom.TabStop = false;
            grpFindAvailableRoom.Text = "Find Available Room";
            // 
            // btnFindRooms
            // 
            btnFindRooms.BackColor = Color.FromArgb(25, 118, 210);
            btnFindRooms.ForeColor = SystemColors.Control;
            btnFindRooms.Location = new Point(695, 60);
            btnFindRooms.Margin = new Padding(3, 4, 3, 4);
            btnFindRooms.Name = "btnFindRooms";
            btnFindRooms.Size = new Size(197, 132);
            btnFindRooms.TabIndex = 2;
            btnFindRooms.Text = "Find Rooms";
            btnFindRooms.UseVisualStyleBackColor = false;
            btnFindRooms.Click += btnFindRooms_Click;
            // 
            // grpGuests
            // 
            grpGuests.Controls.Add(nudNumberOfChildren);
            grpGuests.Controls.Add(nudNumberOfAdults);
            grpGuests.Controls.Add(lblNumberOfChildren);
            grpGuests.Controls.Add(lblNumberOfAdults);
            grpGuests.Location = new Point(466, 45);
            grpGuests.Margin = new Padding(3, 4, 3, 4);
            grpGuests.Name = "grpGuests";
            grpGuests.Padding = new Padding(3, 4, 3, 4);
            grpGuests.Size = new Size(206, 147);
            grpGuests.TabIndex = 1;
            grpGuests.TabStop = false;
            grpGuests.Text = "Guests";
            // 
            // nudNumberOfChildren
            // 
            nudNumberOfChildren.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudNumberOfChildren.Location = new Point(123, 89);
            nudNumberOfChildren.Name = "nudNumberOfChildren";
            nudNumberOfChildren.Size = new Size(53, 27);
            nudNumberOfChildren.TabIndex = 5;
            nudNumberOfChildren.TextAlign = HorizontalAlignment.Center;
            // 
            // nudNumberOfAdults
            // 
            nudNumberOfAdults.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudNumberOfAdults.Location = new Point(123, 47);
            nudNumberOfAdults.Name = "nudNumberOfAdults";
            nudNumberOfAdults.Size = new Size(53, 27);
            nudNumberOfAdults.TabIndex = 1;
            nudNumberOfAdults.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumberOfChildren
            // 
            lblNumberOfChildren.AutoSize = true;
            lblNumberOfChildren.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumberOfChildren.Location = new Point(34, 93);
            lblNumberOfChildren.Name = "lblNumberOfChildren";
            lblNumberOfChildren.Size = new Size(66, 20);
            lblNumberOfChildren.TabIndex = 4;
            lblNumberOfChildren.Text = "Children:";
            // 
            // lblNumberOfAdults
            // 
            lblNumberOfAdults.AutoSize = true;
            lblNumberOfAdults.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumberOfAdults.Location = new Point(47, 51);
            lblNumberOfAdults.Name = "lblNumberOfAdults";
            lblNumberOfAdults.Size = new Size(52, 20);
            lblNumberOfAdults.TabIndex = 3;
            lblNumberOfAdults.Text = "Adults:";
            // 
            // grpDates
            // 
            grpDates.Controls.Add(dtpCheckOutDate);
            grpDates.Controls.Add(lblCheckOutDate);
            grpDates.Controls.Add(dtpCheckInDate);
            grpDates.Controls.Add(label1);
            grpDates.Location = new Point(26, 45);
            grpDates.Margin = new Padding(3, 4, 3, 4);
            grpDates.Name = "grpDates";
            grpDates.Padding = new Padding(3, 4, 3, 4);
            grpDates.Size = new Size(416, 147);
            grpDates.TabIndex = 0;
            grpDates.TabStop = false;
            grpDates.Text = "Dates";
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCheckOutDate.Location = new Point(118, 93);
            dtpCheckOutDate.Margin = new Padding(3, 4, 3, 4);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(278, 27);
            dtpCheckOutDate.TabIndex = 2;
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCheckOutDate.Location = new Point(30, 100);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(81, 20);
            lblCheckOutDate.TabIndex = 2;
            lblCheckOutDate.Text = "Check-Out:";
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCheckInDate.Location = new Point(118, 43);
            dtpCheckInDate.Margin = new Padding(3, 4, 3, 4);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(278, 27);
            dtpCheckInDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(41, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Check-In:";
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvailableRooms.Location = new Point(64, 285);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(126, 20);
            lblAvailableRooms.TabIndex = 1;
            lblAvailableRooms.Text = "Available Rooms";
            // 
            // dgvAvailableRooms
            // 
            dgvAvailableRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAvailableRooms.DefaultCellStyle = dataGridViewCellStyle1;
            dgvAvailableRooms.Location = new Point(64, 317);
            dgvAvailableRooms.Margin = new Padding(3, 4, 3, 4);
            dgvAvailableRooms.Name = "dgvAvailableRooms";
            dgvAvailableRooms.RowHeadersWidth = 51;
            dgvAvailableRooms.RowTemplate.Height = 25;
            dgvAvailableRooms.Size = new Size(913, 200);
            dgvAvailableRooms.TabIndex = 2;
            // 
            // grpGuestInfo
            // 
            grpGuestInfo.Controls.Add(grpFullNameDOB);
            grpGuestInfo.Controls.Add(btnFindGuest);
            grpGuestInfo.Controls.Add(txtEmailAddress);
            grpGuestInfo.Controls.Add(lblEmail);
            grpGuestInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpGuestInfo.Location = new Point(64, 536);
            grpGuestInfo.Margin = new Padding(3, 4, 3, 4);
            grpGuestInfo.Name = "grpGuestInfo";
            grpGuestInfo.Padding = new Padding(3, 4, 3, 4);
            grpGuestInfo.Size = new Size(913, 268);
            grpGuestInfo.TabIndex = 3;
            grpGuestInfo.TabStop = false;
            grpGuestInfo.Text = "Guest Info";
            // 
            // grpFullNameDOB
            // 
            grpFullNameDOB.Controls.Add(dtpDOB);
            grpFullNameDOB.Controls.Add(txtLastName);
            grpFullNameDOB.Controls.Add(lblLastName);
            grpFullNameDOB.Controls.Add(txtMiddleName);
            grpFullNameDOB.Controls.Add(lblMiddleName);
            grpFullNameDOB.Controls.Add(txtFirstName);
            grpFullNameDOB.Controls.Add(lblFirstName);
            grpFullNameDOB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpFullNameDOB.Location = new Point(33, 137);
            grpFullNameDOB.Margin = new Padding(3, 4, 3, 4);
            grpFullNameDOB.Name = "grpFullNameDOB";
            grpFullNameDOB.Padding = new Padding(3, 4, 3, 4);
            grpFullNameDOB.Size = new Size(767, 99);
            grpFullNameDOB.TabIndex = 5;
            grpFullNameDOB.TabStop = false;
            grpFullNameDOB.Text = "Full Name / D.O.B.";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDOB.Location = new Point(517, 32);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(223, 27);
            dtpDOB.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(344, 32);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(149, 27);
            txtLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblLastName.Location = new Point(346, 67);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(35, 20);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last";
            lblLastName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(178, 32);
            txtMiddleName.Margin = new Padding(3, 4, 3, 4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(147, 27);
            txtMiddleName.TabIndex = 6;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(178, 68);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(52, 20);
            lblMiddleName.TabIndex = 5;
            lblMiddleName.Text = "Middle";
            lblMiddleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(23, 32);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(139, 27);
            txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblFirstName.Location = new Point(26, 67);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(36, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFindGuest
            // 
            btnFindGuest.BackColor = Color.FromArgb(25, 118, 210);
            btnFindGuest.ForeColor = SystemColors.Control;
            btnFindGuest.Location = new Point(446, 63);
            btnFindGuest.Margin = new Padding(3, 4, 3, 4);
            btnFindGuest.Name = "btnFindGuest";
            btnFindGuest.Size = new Size(197, 33);
            btnFindGuest.TabIndex = 3;
            btnFindGuest.Text = "Find Guest";
            btnFindGuest.UseVisualStyleBackColor = false;
            btnFindGuest.Click += btnFindGuest_Click;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(139, 63);
            txtEmailAddress.Margin = new Padding(3, 4, 3, 4);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(283, 27);
            txtEmailAddress.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblEmail.Location = new Point(33, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email Address: ";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCreateReservation
            // 
            btnCreateReservation.BackColor = Color.FromArgb(25, 118, 210);
            btnCreateReservation.ForeColor = SystemColors.Control;
            btnCreateReservation.Location = new Point(262, 825);
            btnCreateReservation.Margin = new Padding(3, 4, 3, 4);
            btnCreateReservation.Name = "btnCreateReservation";
            btnCreateReservation.Size = new Size(514, 53);
            btnCreateReservation.TabIndex = 6;
            btnCreateReservation.Text = "Create Reservation";
            btnCreateReservation.UseVisualStyleBackColor = false;
            btnCreateReservation.Click += btnCreateReservation_Click;
            // 
            // frmFindAvailableRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1055, 908);
            Controls.Add(btnCreateReservation);
            Controls.Add(grpGuestInfo);
            Controls.Add(dgvAvailableRooms);
            Controls.Add(lblAvailableRooms);
            Controls.Add(grpFindAvailableRoom);
            Name = "frmFindAvailableRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmFindAvailableRoom_Load;
            grpFindAvailableRoom.ResumeLayout(false);
            grpGuests.ResumeLayout(false);
            grpGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfAdults).EndInit();
            grpDates.ResumeLayout(false);
            grpDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).EndInit();
            grpGuestInfo.ResumeLayout(false);
            grpGuestInfo.PerformLayout();
            grpFullNameDOB.ResumeLayout(false);
            grpFullNameDOB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpFindAvailableRoom;
        private Button btnFindRooms;
        private GroupBox grpGuests;
        private GroupBox grpDates;
        private Label label1;
        private Label lblCheckOutDate;
        private DateTimePicker dtpCheckInDate;
        private DateTimePicker dtpCheckOutDate;
        private Label lblNumberOfChildren;
        private Label lblNumberOfAdults;
        private NumericUpDown nudNumberOfChildren;
        private NumericUpDown nudNumberOfAdults;
        private Label lblAvailableRooms;
        private DataGridView dgvAvailableRooms;
        private GroupBox grpGuestInfo;
        private Label lblEmail;
        private Button btnFindGuest;
        private TextBox txtEmailAddress;
        private GroupBox grpFullNameDOB;
        private TextBox txtFirstName;
        private Button button1;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtMiddleName;
        private Label lblMiddleName;
        private DateTimePicker dtpDOB;
        private Button btnCreateReservation;
    }
}