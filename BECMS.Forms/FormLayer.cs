using BECMS.Forms.Forms;
using BECMS.Forms.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FerPROJ.Design.Forms.FrmManageKrypton;

namespace BECMS.Forms {
    public class FormLayer {
        public static class ManageForm {
            public static bool ManageLogin() {
                using (var frm = new ManageLogin()) {
                    frm.ShowDialog();
                    return frm.CurrentFormResult.Result;
                }
            }
            public async static Task<bool> ManageUser(Guid id, FormMode formMode) {
                using (var frm = new ManageUser()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return await frm.CurrentFormResult;
                }
            }
            public async static Task<bool> ManagePatient(Guid id, FormMode formMode) {
                using (var frm = new ManagePatient()) {
                    frm.Manage_IdTrack = id;
                    frm.CurrentFormMode = formMode;
                    frm.ShowDialog();
                    return await frm.CurrentFormResult;
                }
            }
        }

        public static class ListForm {
            public async static Task<bool> ListUser() {
                using (var frm = new ListUser()) {
                    frm.ShowDialog();
                    return await Task.FromResult(true);
                }
            }
            public async static Task<bool> ListPatient() {
                using (var frm = new ListPatient()) {
                    frm.ShowDialog();
                    return await Task.FromResult(true);
                }
            }
        }
    }
}
