using OfficeScheduler.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler
{
    public partial class formAddPatient : Form
    {
        public formAddPatient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        delegate bool noData(string fldData);
        noData testNoData = d => d.Length == 0; //Lambda function used below to streamline checking for empty text fields
                                                //and prevent them from being added.

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(fldPhone.Text, out int result))
            {
                MessageBox.Show("Phone number must be entered in number-only format.");
            }
            else if (!int.TryParse(fldPostal.Text, out int result1))
            {
                MessageBox.Show("Postal code must be entered in number-only format.");
            }
            else if (!int.TryParse(fldAge.Text, out int result2))
            {
                MessageBox.Show("Age must be entered in number-only format.");
            }
            else if (!int.TryParse(fldSSN.Text, out int result3))
            {
                MessageBox.Show("SSN must be entered in number-only format.");
            }
            //Lambda functions used here; streamlines checking for empty text fields to prevent them from being added
            else if (testNoData(fldLastName.Text) || testNoData(fldFirstName.Text) || testNoData(fldAddress.Text) || testNoData(fldCity.Text) 
                || testNoData(fldState.Text) || testNoData(fldPhone.Text) || testNoData(fldEmail.Text) || testNoData(fldInsuranceID.Text) 
                || testNoData(fldInsuranceGroup.Text) || testNoData(fldSSN.Text))
            {
                MessageBox.Show("Please ensure all necessary paitent information is entered.");
            }
            else
            {
                User.AddPatient((fldFirstName.Text + " " + fldLastName.Text), int.Parse(fldAge.Text), fldAddress.Text, fldAddress2.Text, fldCity.Text, fldState.Text, fldPostal.Text,
                    fldPhone.Text, fldEmail.Text, fldInsuranceID.Text, fldInsuranceGroup.Text, int.Parse(fldSSN.Text), fldAllergies.Text, User.currentUserID);
                this.Close();
            }
        }
    }
}
