using BECMS.Forms;
using FerPROJ.Design.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BECMS.Main {
    public partial class UCLeftSideMenu : CUserControlMenu {
        public UCLeftSideMenu() {
            InitializeComponent();
        }

        protected override void InitializeSideMenu() {
            var dashboardMenu = new BaseMenuButtonModel {
                Title = "Dashboard",
                SubMenus = new List<BaseMenuButtonModel> {
                    new BaseMenuButtonModel{
                        Title = "Home",
                        ButtonColor = Color.LightGray,
                    }
                }
            };

            var manageUserMenu = new BaseMenuButtonModel {
                Title = "Manage Users",
                SubMenus = new List<BaseMenuButtonModel> {
                    new BaseMenuButtonModel{
                        Title = "List",
                        ClickActionAsync = ManageUserAsync,
                        ButtonColor = Color.LightGray,
                    }
                }
            };

            var managePatientMenu = new BaseMenuButtonModel {
                Title = "Manage Patients",
                SubMenus = new List<BaseMenuButtonModel> {
                    new BaseMenuButtonModel{
                        Title = "List",
                        ClickActionAsync = ManagePatientAsync,
                        ButtonColor = Color.LightGray,
                    }
                }
            };

            baseMenuButtonModels.Add(dashboardMenu);
            baseMenuButtonModels.Add(manageUserMenu);
            baseMenuButtonModels.Add(managePatientMenu);

        }
        private async Task ManageUserAsync() {
            await FormLayer.ListForm.ListUser();
        }
        private async Task ManagePatientAsync() {
            await FormLayer.ListForm.ListPatient();
        }
    }
}
