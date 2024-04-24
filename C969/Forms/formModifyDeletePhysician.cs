using OfficeScheduler.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler.Forms
{
    public partial class formModifyDeletePhysician : Form
    {
        public formModifyDeletePhysician()
        {
            InitializeComponent();
            LoadCBSpecialty();
            LoadDGVPhysician();
        }

        public Physician _selectedPhysician = new Physician();

        private void LoadDGVPhysician()
        {
            dgvPhysician.DataSource = User.PhysicianList();
            dgvPhysician.Columns["idphysician"].Visible = false;
            dgvPhysician.Columns["NameAndSpecialty"].Visible = false;
            dgvPhysician.Columns[1].HeaderText = "Name";
            dgvPhysician.Columns[2].HeaderText = "Specialy";
            dgvPhysician.Columns[3].HeaderText = "Phone";
            dgvPhysician.Columns[4].HeaderText = "Email";
            dgvPhysician.ClearSelection();

        }

        private void ClearTextBoxes()
        {
            fldName.Clear();
            fldEmail.Clear();
            fldPhone.Clear();
            cbSpecialty.SelectedIndex = -1;
        }

        private void LoadCBSpecialty()
        {
            cbSpecialty.Items.Add("Adult");
            cbSpecialty.Items.Add("Pediatric");
        }

        private void dgvPhysician_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedPhysician.PhysicianID = (int)dgvPhysician.CurrentRow.Cells["idphysician"].Value;
            _selectedPhysician.Name = dgvPhysician.CurrentRow.Cells["name"].Value.ToString();
            _selectedPhysician.Phone = dgvPhysician.CurrentRow.Cells["phone"].Value.ToString();
            _selectedPhysician.Email = dgvPhysician.CurrentRow.Cells["email"].Value.ToString();
            _selectedPhysician.Specialty = (Physician.SpecialtyEnum)Enum.Parse(typeof(Physician.SpecialtyEnum), dgvPhysician.CurrentRow.Cells["specialty"].Value.ToString());

            fldName.Text = _selectedPhysician.Name;
            fldPhone.Text = _selectedPhysician.Phone;
            fldEmail.Text = _selectedPhysician.Email;
            cbSpecialty.Text = _selectedPhysician.Specialty.ToString();
        }
        delegate bool noData(string fldData);
        noData testNoData = d => d.Length == 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (testNoData(fldName.Text) || testNoData(cbSpecialty.Text) || testNoData(fldPhone.Text) || testNoData(fldEmail.Text))
            {
                MessageBox.Show("Please ensure all physician information is entered.");
            }
            else
            {
                User.ModifyPhysician(_selectedPhysician.PhysicianID, fldName.Text, cbSpecialty.Text, fldPhone.Text, fldEmail.Text, User.currentUserID);
                ClearTextBoxes();
                LoadDGVPhysician();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmDeletion = MessageBox.Show("Are you sure you wish to delete this Physician?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmDeletion == DialogResult.Yes)
            {
                User.DeletePhysician(_selectedPhysician.PhysicianID);
            }
            ClearTextBoxes();
            LoadDGVPhysician();
        }

        private void dgvPhysician_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPhysician.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
