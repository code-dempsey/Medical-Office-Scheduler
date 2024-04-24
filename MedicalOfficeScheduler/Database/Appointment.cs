using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler.Database
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        public int PatientID { get; set; }

        public int PhysicianID { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string VisitReason { get; set; }

        public string Room { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public int ModifiedBy { get; set; }

       
    }
}
    
