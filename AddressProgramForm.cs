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
        // Procedure : Print Name
        // Input : string aptNumber, string streetAddress , string  city, String province, String postalCode
        // Output: Void
        // Description: This Procedure displays a message box given 5 Parameters
        public void PrintName (String aptNumber, String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your Address is: " + aptNumber + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }
        // Procedure : Print Name
        // Input : string streetAddress , string  city, String province, String postalCode
        // Output: Void
        // Description: This Procedure displays a message box given 4 Parameters
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
            // If the user doesn't enter the aptNumber call a procedure that only accepts 4 String Parameters
            if (userAptNumber == "")
            {
                PrintName(userStreetAddress, userCity, userProvince, userProvince, userPostalCode);
            }
            // mAKE THE USER ENTER THE sTREET aDDRESS
            else if (userStreetAddress == " ")
            {
                MessageBox.Show("Please enter your street address", "Address Program");
            }
            // Make the user enter the City
            else if (userCity == " ")
            {
                MessageBox.Show("Please enter your City", "Address Program");
            }
            // Make the user enter a province
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your Province", "Address Program");
            }
            // MAke the user enter a Postal Code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your Postal Code ", "Address Program");
            }
            // if the user enters all the informations, call the procedure that accepts all the strings 
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
