using BECMS.Base.Forms;
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

namespace BECMS.Forms.List {
    public partial class ListUser : ListForm {
        public ListUser() {
            InitializeComponent();
        }
        protected override async Task RefreshData() {
            using(var repo = new UserRepository()) {
                var users = repo.GetAllAsync(searchValue, dateFrom, dateTo);
                await userModelBindingSource.LoadDataAsync(users);
            }
        }
    }
}
