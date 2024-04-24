using DAL;
using Hotel.Repo;
using Hotel_HotelAuberge.Types;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace hotelaubergehotel.WinFrontEnd
{
    public partial class frmClerkAuthentication : Form
    {
        private readonly ClerkRepo clerkRepo;
        public frmClerkAuthentication()
        {
            InitializeComponent();
            clerkRepo = new ClerkRepo();
        }

        private void DisplayMdiForm()
        {
            MDIParent midForm = new MDIParent();

            midForm.FormClosed += midClosed;
            midForm.Show();
            this.Hide();
        }

        private void midClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtAccoutName.Text.Trim();
                var password = txtPassword.Text.Trim();
                int clerkIdFromDatabase = clerkRepo.ValidateClerkCredentials(username, password);

                // If the credentials are valid
                if (clerkIdFromDatabase != 0)
                {
                    ClerkSession.Login(clerkIdFromDatabase);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Abort;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmClerkAuthentication_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
