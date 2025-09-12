using BECMS.Base.Forms;
using BECMS.Models.PatientRecords;
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

namespace BECMS.Forms {
    public partial class ManagePatientRecord : ManageForm {
        PatientRecordModel model = new PatientRecordModel();
        public ManagePatientRecord() {
            InitializeComponent();
        }
        protected override async Task LoadComponentsAsync() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    using (var repo = new PatientRecordRepository()) {
                        model = await repo.GetPrepareModelAsync(model);
                    }
                    break;
                case FormMode.Update:
                    using (var repo = new PatientRecordRepository()) {
                        model = await repo.GetPrepareModelByIdAsync(Manage_IdTrack);
                        model.Items = await repo.GetPrepareModelItemsByParentIdAsync(Manage_IdTrack);
                    }
                    break;
                default:
                    break;
            }
            patientRecordModelBindingSource.DataSource = model;
            patientRecordItemModelBindingSource.DataSource = model.Items;
        }
        protected override async Task InitializeFormPropertiesAsync() {
            // Binding Source
            MainModelBindingSource = patientRecordModelBindingSource;
            ItemModelBindingSource = patientRecordItemModelBindingSource;
            ItemModelDataGridView = patientRecordItemModelCDatagridview;

            cToolstripItems.AddButtonClick += AddButtonClicked;
            await base.InitializeFormPropertiesAsync();
        }
        protected override async Task<bool> OnSaveDataAsync() {
            using (var repo = new PatientRecordRepository()) {
                return await repo.SaveModelAsync(model, model.Items);
            }
        }
        protected override async Task<bool> OnUpdateDataAsync() {
            using (var repo = new PatientRecordRepository()) {
                return await repo.UpdateModelAsync(model, model.Items);
            }
        }
        private async void AddButtonClicked(object sender, EventArgs e) {
            model.Items.Add(new PatientRecordItemModel());
            await RefreshDataSourceAsync();
        }

        private async void linkLabelSelectPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if(await FormLayer.SelectListForm.ListPatient(out Guid id)) {
                using (var repo = new PatientRepository()) {
                    var entity = await repo.GetByIdAsync(id);
                    model.PatientId = entity.Id;
                    model.Name = entity.Name;
                }
            }
            await RefreshDataSourceAsync();
        }
    }
}
