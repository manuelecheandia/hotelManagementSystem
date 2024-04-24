using Hotel.Model.DTO;
using Hotel.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelaubergehotel.WinFrontEnd
{
    public partial class frmViewReservation : Form
    {
        public frmViewReservation()
        {
            InitializeComponent();
        }

        private void btnFindReservation_Click(object sender, EventArgs e)
        {
            try
            {
                ReservationService search = new ReservationService();
                List<ReservationSummaryDTO> summaries = search.GetReservationSummaries(new ReservationSearchInputDTO
                {
                    DateCreated = dtpDateCreated.Value,
                    ConfirmationNumber = txtConfrimationNumber.Text,
                    LastName = txtLastName.Text,
                    CheckInDate = dtpCheckInDate.Value,
                });

                dgvReservations.DataSource = summaries;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
