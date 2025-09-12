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
using static FerPROJ.Design.Forms.FrmManageKrypton;

namespace BECMS.Forms.List {
    public partial class ListUser : ListForm {
        public ListUser() {
            InitializeComponent();
        }
        protected override async Task InitializeFormPropertiesAsync() {
            MainModelDataGridView = userModelCDatagridview;
            await base.InitializeFormPropertiesAsync();
        }
        protected override async Task RefreshDataAsync() {
            using(var repo = new UserRepository()) {
                var users = repo.GetAllAsync(searchValue, dateFrom, dateTo);
                await userModelBindingSource.LoadDataAsync(users);
            }
        }
        protected override async Task<bool> AddNewItemAsync() {
            return await FormLayer.ManageForm.ManageUser(Guid.Empty, FormMode.Add);
        }
        protected override async Task<bool> UpdateItemAsync() {
            if(userModelCDatagridview.GetSelectedValue(Id.Index, out Form_IdTrack)) {
                return await FormLayer.ManageForm.ManageUser(Form_IdTrack.ToGuid(), FormMode.Update);
            }
            return false;
        }
    }
}
