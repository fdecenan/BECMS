using BECMS.Entity.EntityDbContext;
using BECMS.Models.Users;
using FerPROJ.DBHelper.DBExtensions;
using FerPROJ.DBHelper.Helper;
using FerPROJ.Design.Class;
using FerPROJ.Design.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Entity.Users {
    public class UserMigrations : IDbContextMigration<BECMSDbContext> {
        public void Dispose() {
            throw new NotImplementedException();
        }

        public async Task RunMigrationAsync(BECMSDbContext dbContext) {

            DBHelpers.CreateOrUpdateTableOfEntity<User>(dbContext);

            var passowrd = CEncryptionManager.Encrypt("adminpassword");

            if (!dbContext.Users.Any(u => u.UserName == "adminusername")) {
                await dbContext.SaveDTOAndCommitAsync<UserModel, User>(
                    new UserModel {
                        UserName = "adminusername",
                        Name = "System Administrator",
                        Password = passowrd,
                        UserRole = CBaseEnums.Role.Administrator.ToString(),
                    }
                );
            }
        }
    }
}
