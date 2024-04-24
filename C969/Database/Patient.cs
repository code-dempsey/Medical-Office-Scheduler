using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler.Database
{
    public class Patient
    {
        public int PatientID { get; set; } 

        public string Name { get; set;}

        public int Age { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public string  Email { get; set; }

        public string InsuranceID { get; set; }

        public string InsuranceGroup { get; set; }

        public int SSN { get; set; }

        public string Allergies { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public int ModifedBy {  get; set; }  

        public virtual string PatientAgeType()
        {
            string _ageClassification = "NA";
            return _ageClassification;
        }
        
    }

}
