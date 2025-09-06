using BECMS.Base.Forms;
using BECMS.Models.PatientRecords;
using BECMS.Repository;
using FerPROJ.Design.Class;
using System;
using System.Threading.Tasks;
using static FerPROJ.Design.Forms.FrmManageKrypton;

namespace BECMS.Forms.List {
    public partial class ListPatientRecord : ListForm {
        public ListPatientRecord() {
            InitializeComponent();
            patientRecordModelCDatagridview.ApplyCustomAttribute(typeof(PatientRecordModel));
        }
        protected override async Task RefreshData() {
            using (var repo = new PatientRecordRepository()) {
                var entity = repo.GetViewAsync(searchValue, dateFrom: dateFrom, dateTo: dateTo);
                await patientRecordModelBindingSource.LoadDataAsync(entity);
            }
        }
        protected override async Task<bool> AddNewItem() {
            return await FormLayer.ManageForm.ManagePatientRecord(Guid.Empty, FormMode.Add);
        }
        protected override async Task<bool> UpdateItem() {
            if (patientRecordModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)) {
                return await FormLayer.ManageForm.ManagePatientRecord(Form_IdTrack.ToGuid(), FormMode.Update);
            }
            return false;
        }
    }
}
