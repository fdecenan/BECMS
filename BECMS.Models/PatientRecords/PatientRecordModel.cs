using FerPROJ.Design.BaseModels;
using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Models.PatientRecords {
    public class PatientRecordModel : BaseModel {
        [GridColumnAttributes(IsVisible = false)]
        public Guid PatientId { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public DateTime VisitDate { get; set; } = DateTime.Now;
        public DateTime FollowUpDate { get; set; } = DateTime.Now.AddDays(10);
        [GridColumnAttributes(IsVisible = false)]
        public Guid AssignUserId { get; set; }
        public List<PatientRecordItemModel> Items { get; set; } = new List<PatientRecordItemModel>();
        public override bool DataValidation() {
            throw new NotImplementedException();
        }
    }
}
