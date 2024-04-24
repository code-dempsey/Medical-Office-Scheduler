using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeScheduler.Database
{
    public class Physician
    {
        public int PhysicianID { get; set; }

        public string Name { get; set; }

        public enum SpecialtyEnum { Pediatric, Adult }

        public SpecialtyEnum Specialty { get; set; }

        public string Phone { get; set; }   

        public string Email { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public int ModifiedBy { get; set; }

    }
}
