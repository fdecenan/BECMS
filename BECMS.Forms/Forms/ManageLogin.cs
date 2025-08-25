using BECMS.Base.Forms;
using BECMS.Models.Users;
using BECMS.Repository;
using FerPROJ.DBHelper.Helper;
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
    public partial class ManageLogin : ManageForm {
        UserModel userModel = new UserModel();
        public ManageLogin() {
            InitializeComponent();
        }

        protected override async Task LoadComponents() {
            userModelBindingSource.DataSource = userModel;
            userModel.UserName = CLibFilesReader.GetRememberedUsername(cbRememberMe, userNameCTextBoxKrypton);
            await Task.CompletedTask;
        }

        protected override void InitializeKeyboardShortcuts() {
            keyboardShortcuts[Keys.F1] = DBHelpers.OpenDatabaseConfiguration;
        }

        private async void cButtonLogin_Click(object sender, EventArgs e) {
            if (await OnSaveData()) {
                CurrentFormResult = Task.FromResult(true);
                this.Close();
            }
        }
        protected override async Task<bool> OnSaveData() {
            using (var repo = new UserRepository()) {
                return await repo.CheckCredentialsAsync(userModel);
            }
        }
    }
}
