using BECMS.Base.Forms;
using BECMS.Models.Users;
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
    public partial class ManageUser : ManageForm {
        UserModel model = new UserModel();
        public ManageUser() {
            InitializeComponent();
        }
        protected override async Task LoadComponents() {
            userRoleCComboBoxKrypton.FillComboBoxEnum<CEnum.Role>();
            switch (CurrentFormMode) {
                case FormMode.Add:
                    break;
                case FormMode.Update:
                    using (var repo = new UserRepository()) {
                        var entity = await repo.GetByIdAsync(Manage_IdTrack);
                        model = entity.ToDestination<UserModel>();
                        model.Password = CEncryption.Decrypt(entity.Password);
                    }
                    break;
                default:
                    break;
            }
            userModelBindingSource.DataSource = model;
        }
        protected override async Task<bool> OnSaveData() {
            using (var repo = new UserRepository()) {
                return await repo.SaveDTOAsync(model, true);
            }
        }
        protected override async Task<bool> OnUpdateData() {
            using (var repo = new UserRepository()) {
                return await repo.UpdateDTOAsync(model, true);
            }
        }
    }
}
