using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Reports.Models {
    public class PatientPrescriptionModel {
        public Guid Id { get; set; } 
        public string FormId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; } 
        public string DateCreatedString => DateCreated.ToString("MMMM dd, yyyy hh:mm tt");
        public string DateModifiedString => !DateModified.HasValue ? string.Empty : DateModified.Value.ToString("MMMM dd, yyyy hh:mm tt");
        public DateTime? DateModified { get; set; } 
        public string CreatedBy { get; set; } 
        public string ModifiedBy { get; set; } 
        public string Status { get; set; } 
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } 
        public string Gender { get; set; }
        public string PatientStatus { get; set; }
        public string PatientAddress { get; set; }
        public DateTime Birthdate { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; } 
        public string Occupation { get; set; }
        public string ReferredBy { get; set; } 
    }
}
