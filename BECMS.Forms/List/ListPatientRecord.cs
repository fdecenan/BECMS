using BECMS.Base.Forms;
using BECMS.Repository;
using FerPROJ.Design.Class;
using System;
using System.Threading.Tasks;
using static FerPROJ.Design.Forms.FrmManageKrypton;

namespace BECMS.Forms.List {
    public partial class ListPatientRecord : ListForm {
        public ListPatientRecord() {
            InitializeComponent();
        }
        protected override async Task InitializeFormPropertiesAsync() {
            MainModelDataGridView = patientRecordModelCDatagridview;
            await base.InitializeFormPropertiesAsync();
        }
        protected override async Task RefreshDataAsync() {
            using (var repo = new PatientRecordRepository()) {
                var entity = repo.GetViewAsync(searchValue, dateFrom: dateFrom, dateTo: dateTo);
                await patientRecordModelBindingSource.LoadDataAsync(entity);
            }
        }
        protected override async Task<bool> AddNewItemAsync() {
            return await FormLayer.ManageForm.ManagePatientRecord(Guid.Empty, FormMode.Add);
        }
        protected override async Task<bool> UpdateItemAsync() {
            if (patientRecordModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)) {
                return await FormLayer.ManageForm.ManagePatientRecord(Form_IdTrack.ToGuid(), FormMode.Update);
            }
            return false;
        }
        protected override async Task<bool> DeleteItemAsync() {
            if (patientRecordModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)) {
                using (var repo = new PatientRecordRepository()) {
                    return await repo.DeleteByIdAsync(Form_IdTrack.ToGuid());
                }
            }
            return false;
        }
    }
}
