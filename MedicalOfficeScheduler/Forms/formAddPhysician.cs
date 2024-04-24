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

namespace OfficeScheduler.Forms
{
    public partial class formAddPhysician : Form
    {
        public formAddPhysician()
        {
            InitializeComponent();
            LoadCBSpecialty();
        }

        private void LoadCBSpecialty()
        {
            cbSpecialty.Items.Add("Adult");
            cbSpecialty.Items.Add("Pediatric");
        }
        delegate bool noData(string fldData);
        noData testNoData = d => d.Length == 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (testNoData(fldEmail.Text) || testNoData(fldFirstName.Text) || testNoData(fldLastName.Text) || testNoData(fldPhone.Text) || testNoData(cbSpecialty.Text))
            {
                MessageBox.Show("Please ensure all necessary physician information is entered.");
            }
            else
            {
                User.AddPhysician(fldFirstName.Text + " " + fldLastName.Text, cbSpecialty.Text, fldPhone.Text, fldEmail.Text, User.currentUserID);
                this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
