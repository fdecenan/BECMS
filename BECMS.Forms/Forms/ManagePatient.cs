using BECMS.Base.Forms;
using BECMS.Models.Patients;
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

namespace BECMS.Forms.Forms {
    public partial class ManagePatient : ManageForm {
        PatientModel model = new PatientModel();
        public ManagePatient() {
            InitializeComponent();
        }
        protected override async Task LoadComponents() {
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var repo = new PatientRepository()) {
                        var entity = await repo.GetByIdAsync(Manage_IdTrack);
                        model = entity.ToDestination<PatientModel>();
                    }
                    break;
                default:
                    break;
            }
            patientModelBindingSource.DataSource = model;
        }
        protected override async Task<bool> OnSaveData() {
            using (var repo = new PatientRepository()) {
                return await repo.SaveDTOAsync(model, true);
            }
        }
        protected override async Task<bool> OnUpdateData() {
            using (var repo = new PatientRepository()) {
                return await repo.UpdateDTOAsync(model, true);
            }
        }
    }
}
