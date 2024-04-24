using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeScheduler.Database;

namespace OfficeScheduler.Forms
{
    public partial class formAppsByPatientReport : Form
    {
        public formAppsByPatientReport(int customerId)
        {
            InitializeComponent();
            loadDGVAppsByCust(customerId);
        }
        private void loadDGVAppsByCust(int customerId)
        {
            lblAppsByCust.Text = $"All appointments for {User.GetPatientNameFromID(customerId)}:" + "\n"  + "Report ran on: " + DateTime.Now.ToString();
            dgvAppsByCust.DataSource = User.AppsByPatient(customerId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
