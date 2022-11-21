using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class ChooseAddressForm : Form
    {
        private List<Address> addressList; 

        // Prepaer GUI fro display
        public ChooseAddressForm(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
        }

        public int AddressIndex
        {
          // Pre - The user has selected the combobox
            get
            {
                return CAComboBox.SelectedIndex;
            }

            set
            {
                if ((value < addressList.Count) && (value >= -1))
                    CAComboBox.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException
                        ("AddressIndex", value, "Must Have a Valid Index");
            }
        }


        // Fill the combobox with existing addresses in the system
        private void ChooseAddressForm_Load_1(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                CAComboBox.Items.Add(a.Name);
            }

            CAComboBox.SelectedIndex = 0; 
        }

        // Close form if user presses cancel button
        // utilizes mouse down as to bypass error provider
        private void CACancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Validating that will activate error provider if the information isnt valid
        private void CAComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (CAComboBox.SelectedIndex == -1) 
            {
                e.Cancel = true;
                CAerrorProv.SetError(CAComboBox, "Select an address");
            }
        }

        // Validation that the information is valid and that error provider will not halt the process
        private void CAComboBox_Validated(object sender, EventArgs e)
        {
            CAerrorProv.SetError(CAComboBox, "");
        }

        // Ok button has been clicked
        // data will be processed if valid and error provider doesn't cease the operation
        private void CAOKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
