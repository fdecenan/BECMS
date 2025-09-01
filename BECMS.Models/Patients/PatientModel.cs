using FerPROJ.Design.BaseModels;
using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Models.Patients {
    public class PatientModel : BaseModel {
        public int Age => Birthdate.GetAge();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = null;
        public string Gender { get; set; }
        public string PatientStatus { get; set; }
        public string PatientAddress { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; } = null;
        public string Occupation { get; set; }
        public string ReferredBy { get; set; } = null;

        public override bool DataValidation() {

            Name = $"{FirstName} {(!string.IsNullOrEmpty(MiddleName) ? MiddleName[0] + ". " : "")}{LastName}";

            return true;
        }
    }
}
