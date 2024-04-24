using Hotel_Auberge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelaubergehotel.WinFrontEnd
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
        private Form? childForm = new Form();

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            ToolStripMenuItem manuItems = (ToolStripMenuItem)sender;
            string? tagValue = manuItems.Tag.ToString();

            switch (tagValue)
            {
                case "FindAvailableRoom":
                    childForm = new frmFindAvailableRoom();
                    break;
                case "ViewReservation":
                    childForm = new frmViewReservation();
                    break;
                case "CreateGuest":
                    childForm = new frmCreateGuest();
                    break;
            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        f.Activate();
                        return;
                    }
                }

                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void MDIParent_Load(object sender, EventArgs e)
        {

            try
            {
                using (frmClerkAuthentication loginForm = new frmClerkAuthentication())
                {
                    loginForm.StartPosition = FormStartPosition.CenterScreen;

                    DialogResult result = loginForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("You are authenticated");
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("You canceled the login");
                        this.Close();
                    }
                    else if (result == DialogResult.Abort)
                    {
                        MessageBox.Show("You are not authorized");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
