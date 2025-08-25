using FerPROJ.DBHelper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Entity.Patients {
    public class Patient : BaseEntity {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = null;
        public string Gender { get; set; }
        public string PatientStatus { get; set; }
        public string PatientAddress { get; set; }
        public DateTime Birthdate { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; } = null;
        public string Occupation { get; set; }
        public string ReferredBy { get; set; } = null;

    }
}
