using BECMS.Entity.EntityDbContext;
using BECMS.Entity.Users;
using BECMS.Models.Users;
using FerPROJ.DBHelper.Base;
using FerPROJ.DBHelper.DBExtensions;
using FerPROJ.Design.Controls;
using FerPROJ.Design.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Repository {
    public class UserRepository : BaseDBEntityAsync<BECMSDbContext, UserModel, User, Guid>, IEntityDataAsync<User> {
        public UserRepository() {
        }

        public UserRepository(BECMSDbContext ts) : base(ts) {
        }

        public Task<IEnumerable<User>> GetAllAsync(string searchText, DateTime? dateFrom, DateTime? dateTo) {
            throw new NotImplementedException();
        }

        public Task<string> GetNewIDAsync() {
            throw new NotImplementedException();
        }

        public Task LoadComboBoxAsync(CComboBoxKrypton cmb) {
            throw new NotImplementedException();
        }
    }
}
