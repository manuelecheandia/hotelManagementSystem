namespace hotelaubergehotel.WinFrontEnd
{
    partial class frmClerkAuthentication
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
            txtAccoutName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblWelcome = new Label();
            Password = new Label();
            label2 = new Label();
            btnCancel = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // txtAccoutName
            // 
            txtAccoutName.Location = new Point(44, 119);
            txtAccoutName.Margin = new Padding(3, 2, 3, 2);
            txtAccoutName.Multiline = true;
            txtAccoutName.Name = "txtAccoutName";
            txtAccoutName.Size = new Size(288, 26);
            txtAccoutName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(44, 204);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(25, 118, 210);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(64, 273);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(235, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = SystemColors.WindowFrame;
            lblWelcome.Location = new Point(130, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(136, 30);
            lblWelcome.TabIndex = 12;
            lblWelcome.Text = "Clerk Login";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = SystemColors.WindowFrame;
            Password.Location = new Point(44, 180);
            Password.Name = "Password";
            Password.Size = new Size(62, 15);
            Password.TabIndex = 13;
            Password.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(44, 95);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 14;
            label2.Text = "Accout Name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(64, 319);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(235, 41);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(130, 232);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 15;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // frmClerkAuthentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(395, 388);
            Controls.Add(chkShowPassword);
            Controls.Add(btnCancel);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtAccoutName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmClerkAuthentication";
            Text = "frmClerkAuthentication";
            Load += frmClerkAuthentication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccoutName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblWelcome;
        private Label Password;
        private Label label2;
        private Button btnCancel;
        private CheckBox chkShowPassword;
    }
}