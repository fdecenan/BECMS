using FerPROJ.Design.BaseModels;
using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Models.PatientRecords {
    public class PatientRecordItemModel : BaseModelItem {
        [CDGVAttributes(IsEditable = true)]
        public string TreatmentPlan { get; set; }
        [CDGVAttributes(IsEditable = true)]
        public string Prescription { get; set; }
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
