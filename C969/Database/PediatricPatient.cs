using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeScheduler.Database
{
    public class PediatricPatient : Patient
    {
        public override string PatientAgeType()
        {
            return "Pediatric";
        }
    }
}
