using BECMS.Entity.EntityDbContext;
using BECMS.Entity.Users;
using BECMS.Models.Users;
using FerPROJ.DBHelper.Base;
using FerPROJ.DBHelper.DBExtensions;
using FerPROJ.Design.Class;
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

        public async Task<IEnumerable<User>> GetAllAsync(string searchText, DateTime? dateFrom, DateTime? dateTo) {
            var query = await GetAllWithSearchAsync(searchText, dateFrom, dateTo);
            return query;
        }

        public Task<string> GetNewIDAsync() {
            throw new NotImplementedException();
        }

        public Task LoadComboBoxAsync(CComboBoxKrypton cmb) {
            throw new NotImplementedException();
        }

        public async Task<bool> CheckCredentialsAsync(UserModel model) {
            
            model.Password = CEncryption.Encrypt(model.Password);

            var entity = await GetByPredicateAsync(c=>c.UserName == model.UserName && c.Password == model.Password);

            if(entity == null) {
                CShowMessage.Warning("Invalid username or password.");
                return false;
            }

            CStaticVariable.USERNAME = entity.UserName;
            CStaticVariable.USER_ID = entity.Id;

            return true;

        }
    }
}
