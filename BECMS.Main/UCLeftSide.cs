using BECMS.Forms;
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
    public partial class UCLeftSide : UserControl {
        private Timer timer;
        private int targetHeight;
        private int step;
        private Panel _panel = new Panel();
        public UCLeftSide() {
            InitializeComponent();
            LoadSideMenuDefault();
            timer = new Timer();
            timer.Interval = 10; 
            timer.Tick += Timer_Tick;
        }
        private void LoadSideMenuDefault() {
            panelDashboard.Height = 54;
            panelPatients.Height = 54;
            panelUser.Height = 54;
        }
        private void Timer_Tick(object sender, EventArgs e) {
            int currentHeight = _panel.Height;

            if ((step > 0 && currentHeight >= targetHeight) || (step < 0 && currentHeight <= targetHeight)) {
                timer.Stop();
                _panel.Height = targetHeight;
            }
            else {
                _panel.Height += step;
            }
        }
        private void ChangeHeight(Panel panel, int buttonCount = 3) {
            int currentHeight = panel.Height;
            var backColor = panel.BackColor;

            if (currentHeight == 54) {
                targetHeight = 54 * buttonCount;
                step = 5; // Increase height
            }
            else {
                targetHeight = 54;
                step = -5; // Decrease height
            }
            _panel = panel;
            timer.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e) {
            ChangeHeight(panelDashboard, 2);
        }

        private void btnManageUser_Click(object sender, EventArgs e) {
            ChangeHeight(panelUser, 2);
        }

        private void btnManagePatients_Click(object sender, EventArgs e) {
            ChangeHeight(panelPatients, 2);
        }

        private async void btnListUser_Click(object sender, EventArgs e) {
            await FormLayer.ListForm.ListUser();
        }

        private async void btnListPatients_Click(object sender, EventArgs e) {
            await FormLayer.ListForm.ListPatient();
        }
    }
}
