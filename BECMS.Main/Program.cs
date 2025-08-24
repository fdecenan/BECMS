using BECMS.Entity.EntityDbContext;
using BECMS.Entity.Users;
using BECMS.Forms;
using FerPROJ.DBHelper.DBCache;
using FerPROJ.DBHelper.Helper;
using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECMS.Main {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CAssembly.SetAssembly(Assembly.GetExecutingAssembly());
            try {
                if (FormLayer.ManageForm.ManageLogin()) {
                    LoadCacheAsync();
                    Application.Run(new Dashboard());
                }
            }
            catch (Exception ex) {
                CShowMessage.Warning(ex.Message);
            }
        }
        static async void LoadCacheAsync() {
            await FrmSplasher.ShowSplashAsync(
                CacheManager.GetCacheLoadTasks(typeof(BECMSDbContext))
            );
        }
    }
}
