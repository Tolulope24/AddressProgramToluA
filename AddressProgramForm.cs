using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressProgramToluA
{
    public partial class frmAddressProgram : Form
    {
        public frmAddressProgram()
        {
            InitializeComponent();
        }
        public void PrintName (String aptNumber, String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your Address is: " + aptNumber + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        public void PrintName (String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your Address is: " + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode;

            userAptNumber = this.txtAptNumber.Text;
            userStreetAddress = this.txtStreetAddress.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;

            if (userAptNumber == "")
            {
                PrintName(userStreetAddress, userCity, userProvince, userProvince);
            }
            else if (userStreetAddress == "")
            {
                MessageBox.Show("Please enter your street address", "Address Program");
            }
            else if (userCity == "")
            {
                MessageBox.Show("Please enter your City", "Address Program");
            }
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your Province", "Address Program");
            }
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your Postal Code ", "Address Program");
            }
            else
            {
                PrintName(userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode);
            }
                


        }

        private void frmAddressProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
