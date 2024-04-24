using System;
using System.Windows.Forms;
using Hotel.Model.DTO;
using Hotel.Service;
using Hotel_HotelAuberge.Model;
using hotelaubergehotel.WinFrontEnd;


namespace Hotel_Auberge
{
    public partial class frmFindAvailableRoom : Form
    {
        private GuestService guestService;
        private GuestDTO foundGuest;
        private ReservationService reservationService;

        public frmFindAvailableRoom()
        {
            InitializeComponent();
            guestService = new GuestService();
            reservationService = new ReservationService();
        }

        private void frmFindAvailableRoom_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnFindRooms_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime checkInDate = dtpCheckInDate.Value;
                DateTime checkOutDate = dtpCheckOutDate.Value;

                int numberOfAdults = (int)nudNumberOfAdults.Value;
                int numberOfChildren = (int)nudNumberOfChildren.Value;

                int totalGuests = numberOfAdults + numberOfChildren;

                RoomService roomService = new RoomService();
                (List<AvailableRoomsDTO> availableRooms, List<ValidationError> errors) = roomService.GetAvailableRooms(new AvailableRoomsInputDTO
                {
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    NumberOfGuests = totalGuests
                });


                if (errors != null)
                {
                    foreach (ValidationError error in errors)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    dgvAvailableRooms.DataSource = availableRooms;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFindGuest_Click(object sender, EventArgs e)
        {
            var emailAddress = txtEmailAddress.Text.Trim();

            if (!string.IsNullOrWhiteSpace(emailAddress))
            {
                foundGuest = guestService.FindGuestByEmail(emailAddress);

                if (foundGuest != null)
                {
                    txtFirstName.Text = foundGuest.FirstName ?? "";
                    txtMiddleName.Text = foundGuest.MiddleName ?? "";
                    txtLastName.Text = foundGuest.LastName ?? "";
                    dtpDOB.Value = foundGuest.DateOfBirth;
                }
                else
                {
                    var result = MessageBox.Show("Guest not found. Do you want to create a new one?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        var createGuestForm = new frmCreateGuest();
                        createGuestForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter an email address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if (foundGuest != null)
            {
                if (dgvAvailableRooms.SelectedRows.Count > 0)
                {
                    int roomId = Convert.ToInt32(dgvAvailableRooms.SelectedRows[0].Cells["RoomId"].Value);

                    DateTime checkInDate = dtpCheckInDate.Value;
                    DateTime checkOutDate = dtpCheckOutDate.Value;
                    int numOfAdults = (int)nudNumberOfAdults.Value;
                    int numOfChildren = (int)nudNumberOfChildren.Value;

                    ReservationCreateDTO newReservation = new ReservationCreateDTO
                    {
                        GuestId = foundGuest.Id,
                        RoomId = roomId,
                        CheckInDate = checkInDate,
                        CheckOutDate = checkOutDate,
                        NumAdults = numOfAdults,
                        NumChildren = numOfChildren,
                    };

                    bool success = reservationService.CreateReservation(newReservation);

                    if (success)
                    {
                        MessageBox.Show($"Reservation added successfully! " +
                            $"Confirmation Number is {newReservation.ConfirmationNumber}");

                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create reservation.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a room from the available rooms.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var result = MessageBox.Show("Guest not found. Do you want to create a new one?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    var createGuestForm = new frmCreateGuest();
                    createGuestForm.Show();
                }
            }
        }

        private void ClearForm()
        {
            dtpCheckInDate.Value = DateTime.Today;
            dtpCheckOutDate.Value = DateTime.Today;

            nudNumberOfAdults.Value = 0;
            nudNumberOfChildren.Value = 0;

            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;

            dtpDOB.Value = DateTime.Today;

            dgvAvailableRooms.DataSource = null;
            dgvAvailableRooms.Rows.Clear();

        }
    }
}