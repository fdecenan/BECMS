using FerPROJ.DBHelper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Entity.PatientRecords {
    public class PatientRecordItem : BaseEntityItem {
        public string TreatmentPlan { get; set; }
        public string Prescription { get; set; }
    }
}
