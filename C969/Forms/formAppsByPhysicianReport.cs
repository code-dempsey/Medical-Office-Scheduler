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
    public partial class formAppsByPhysicianReport : Form
    {
        public formAppsByPhysicianReport(int userID)
        {
            InitializeComponent();
            loadDGVAppsByCust(userID);
        }
        private void loadDGVAppsByCust(int userID)
        {
            lblAppsByUser.Text = $"All appointments for {User.GetPhysicianNameFromID(userID)}:" + "\n" + "Report ran on: " + DateTime.Now.ToString();
            dgvAppsByUser.DataSource = User.AppsByPhysician(userID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
