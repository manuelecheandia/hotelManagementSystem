using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelaubergehotel.WinFrontEnd
{
    internal class UIUtilities
    {
        // Binds a list of data to a ComboBox.
        public static void BindDataToComboBox<Type>(ComboBox comboBox,
            List<Type> data, string displayMember, string valueMember)
        {
            comboBox.DataSource = data;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;
        }
    }
}
