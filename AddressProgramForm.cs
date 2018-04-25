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
            String userAptNumber, UserStreetAddress, UserCity, UserProvince, userPostalCode;
        }
    }
}
