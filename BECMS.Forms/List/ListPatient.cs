using BECMS.Base.Forms;
using BECMS.Reports;
using BECMS.Repository;
using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FerPROJ.Design.Forms.FrmManageKrypton;

namespace BECMS.Forms.List {
    public partial class ListPatient : ListForm {
        public ListPatient() {
            InitializeComponent();
        }
        protected override async Task RefreshData() {
            using (var repo = new PatientRepository()) {
                var entity = repo.GetAllAsync(searchValue, dateFrom, dateTo);
                await patientModelBindingSource.LoadDataAsync(entity);
            }
        }
        protected override async Task<bool> AddNewItem() {
            return await FormLayer.ManageForm.ManagePatient(Guid.Empty, FormMode.Add);
        }
        protected override async Task<bool> UpdateItem() {
            if(patientModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)){
                return await FormLayer.ManageForm.ManagePatient(Form_IdTrack.ToGuid(), FormMode.Update);
            }
            return false;
        }
        protected override async Task<bool> ViewItem() {
            if (patientModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)) {
                await new TransactionReport().PreviewReportAsync(TransactionReport.ReportList.PatientPrescriptionReport, Form_IdTrack.ToGuid());
            }
            return true;
        }
        protected override async Task<bool> DeleteItem() {
            if (patientModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)) {
                using (var repo = new PatientRepository()) {
                    return await repo.DeleteByIdAsync(Form_IdTrack.ToGuid());
                }
            }
            return true;
        }
        protected override async Task<bool> GetSelectedData() {
            return await Task.FromResult(patientModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack));
        }
    }
}
