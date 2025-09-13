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
    public class UserRepository : BaseRepository<BECMSDbContext, UserModel, User, Guid>, IModelViewAsync<UserModel> {
        public UserRepository() {
        }

        public UserRepository(BECMSDbContext ts) : base(ts) {
        }

        public async Task<IEnumerable<UserModel>> GetViewAsync(string searchText = "", DateTime? dateFrom = null, DateTime? dateTo = null, int dataLimit = 100) {
            
            var query = await GetAllWithSearchAsync(searchText, dateFrom, dateTo);

            var result = await query.SelectListAsync(async c => {
                
                var model = c.ToDestination<UserModel>();
                
                await Task.CompletedTask;
                
                return model;

            }, model => model.SearchForDate(dateFrom, dateTo), dataLimit);

            return result;
        }

        public Task<string> GetNewIDAsync() {
            throw new NotImplementedException();
        }

        public Task LoadComboBoxAsync(CComboBoxKrypton cmb) {
            throw new NotImplementedException();
        }

        public async Task<bool> CheckCredentialsAsync(UserModel model) {
            
            model.Password = CEncryptionManager.EncryptText(model.Password);

            var entity = await GetByPredicateAsync(c=>c.UserName == model.UserName && c.Password == model.Password);

            if(entity == null) {
                CDialogManager.Warning("Invalid username or password.");
                return false;
            }

            CAppConstants.USERNAME = entity.UserName;
            CAppConstants.USER_ID = entity.Id;

            return true;

        }
    }
}
