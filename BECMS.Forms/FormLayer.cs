using BECMS.Forms.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Forms {
    public class FormLayer {
        public static class ManageForm {
            public static bool ManageLogin() {
                using (var frm = new ManageLogin()) {
                    frm.ShowDialog();
                    return frm.CurrentFormResult.Result;
                }
            }
        }

        public static class ListForm {

        }
    }
}
