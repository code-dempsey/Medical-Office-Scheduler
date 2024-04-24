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
    public partial class formAppsByPhysMonth : Form
    {
        public formAppsByPhysMonth(int intMonth, int intYear, int physicianID)
        {
            InitializeComponent();
            loadDGVAppsByCust(intMonth, intYear, physicianID);
        }
        private void loadDGVAppsByCust(int intMonth, int intYear, int physicianID)
        {
            dgvAppsByPhysMonth.DataSource = User.AppsByPhysicianMonth(intMonth, intYear, physicianID);
            
            lblAppsByUser.Text = $"All appointments for {User.GetPhysicianNameFromID(physicianID)}:" +"\n" + "Report ran on: " + DateTime.Now.ToString();

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
