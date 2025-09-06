using FerPROJ.DBHelper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Entity.PatientRecords {
    public class PatientRecord : BaseEntity {
        public Guid PatientId { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime FollowUpDate { get; set; }
        public Guid AssignUserId { get; set; }
    }
}
