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

namespace BECMS.Main {
    public partial class Dashboard : Form {
        public Dashboard() {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            cLabelDateTime.Text = CAccessManager.CurrentDateTime(true);
            cLabelTitleUser.Text = CAppConstants.USERNAME;
            cLabelTitleVersion.Text = CBaseAssembly.SystemVersion;
        }
    }
}
