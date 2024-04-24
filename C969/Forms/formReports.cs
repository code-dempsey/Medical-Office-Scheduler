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
    public partial class formReports : Form
    {
        public formReports()
        {
            InitializeComponent();

            loadCBPhysician();
            loadCBPatient();
        }

        private void loadCBPhysician()
        {
            cbPhysician1.DataSource = User.PhysicianList().DataSource;
            cbPhysician1.DisplayMember = "name";
            cbPhysician1.ValueMember = "idphysician";
            cbPhysician1.SelectedIndex = -1;

            cbPhysician.DataSource = User.PhysicianList().DataSource;
            cbPhysician.DisplayMember = "name";
            cbPhysician.ValueMember = "idphysician";
            cbPhysician.SelectedIndex = -1;
        }
        private void loadCBPatient()
        {
            cbPatient.DataSource = User.PopulatePatientDGV().DataSource;
            cbPatient.DisplayMember = "name";
            cbPatient.ValueMember = "idpatient";
            cbPatient.SelectedIndex = -1;
        }


        private void btnAppByMonth_Click(object sender, EventArgs e)
        {           
            if (cbPhysician.SelectedValue != null)
            {
                Form formAppsByPhysMonth = new formAppsByPhysMonth(int.Parse(dtpAppointment.Value.ToString("MM")), int.Parse(dtpAppointment.Value.ToString("yyyy")), int.Parse(cbPhysician.SelectedValue.ToString()));
                formAppsByPhysMonth.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a physician.");
            }
                     
        }
        private void btnShowCSReport_Click(object sender, EventArgs e)
        {
            if (cbPhysician1.SelectedValue != null)
            {
                Form appsUserReport = new formAppsByPhysicianReport(int.Parse(cbPhysician1.SelectedValue.ToString()));
                appsUserReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a physician.");
            }
        }
        private void btShowACReport_Click(object sender, EventArgs e)
        {
            if (cbPatient.SelectedValue != null)
            {
                Form appsCustReport = new formAppsByPatientReport(int.Parse(cbPatient.SelectedValue.ToString()));
                appsCustReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
