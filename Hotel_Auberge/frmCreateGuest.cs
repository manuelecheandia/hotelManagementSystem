using Hotel.Model.DTO;
using Hotel.Service;

namespace hotelaubergehotel.WinFrontEnd
{
    public partial class frmCreateGuest : Form
    {
        private readonly GuestService guestService;
        private readonly ListsService listsService;

        public frmCreateGuest()
        {
            InitializeComponent();
            guestService = new GuestService();
            listsService = new ListsService();
        }
        private void frmCreateGuest_Load(object sender, EventArgs e)
        {
            List<CountryListDTO> country = listsService.GetCountries();
            UIUtilities.BindDataToComboBox(cboCountry, country, "Name", "Id");

            List<ProvinceListDTO> province = listsService.GetProvinces(); 
            UIUtilities.BindDataToComboBox(cboProvince, province, "Name", "Id");

            
        }

        private void btnCreateGuest_Click(object sender, EventArgs e)
        {
            CountryListDTO selectedCountry = (CountryListDTO)cboCountry.SelectedItem;
            ProvinceListDTO selectedProvince = (ProvinceListDTO)cboProvince.SelectedItem;

            GuestDTO guestDTO = new GuestDTO
            {
                FirstName = txtGuestFirstName.Text,
                MiddleName = txtGuestMiddleName.Text,
                LastName = txtGuestLastName.Text,
                DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value),
                StreetAddress = txtGuestMunicipality.Text,
                Municipality = txtGuestMunicipality.Text,
                PostalCode = txtGuestPostalCode.Text,
                PrimaryPhoneNumber = txtGuestPrimaryPhoneNumber.Text,
                SecondaryPhoneNumber = txtGuestSecondaryPhoneNumber.Text,
                EmailAddress = txtGuestEmailAddress.Text,
                CountryId = selectedCountry.Id, 
                ProvinceId = selectedProvince.Id
            };

            bool success = guestService.CreateGuest(guestDTO);

            if (success)
            {
                MessageBox.Show("Guest created successfully.");
            }
            else
            {
                MessageBox.Show("Failed to create guest.");
            }

        }
    }
}
