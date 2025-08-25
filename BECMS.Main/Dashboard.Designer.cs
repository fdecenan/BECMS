namespace BECMS.Main {
    partial class Dashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.ucLeftSide1 = new BECMS.Main.UCLeftSide();
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.ucRightSide1 = new BECMS.Main.UCRightSide();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftSidePanel.SuspendLayout();
            this.panelRightSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.topPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 756);
            this.panel1.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1285, 119);
            this.topPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelCenter);
            this.panel3.Controls.Add(this.panelRightSide);
            this.panel3.Controls.Add(this.leftSidePanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1285, 635);
            this.panel3.TabIndex = 1;
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftSidePanel.Controls.Add(this.ucLeftSide1);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(275, 635);
            this.leftSidePanel.TabIndex = 0;
            // 
            // ucLeftSide1
            // 
            this.ucLeftSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLeftSide1.Location = new System.Drawing.Point(0, 0);
            this.ucLeftSide1.Name = "ucLeftSide1";
            this.ucLeftSide1.Size = new System.Drawing.Size(273, 633);
            this.ucLeftSide1.TabIndex = 0;
            // 
            // panelRightSide
            // 
            this.panelRightSide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelRightSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRightSide.Controls.Add(this.ucRightSide1);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightSide.Location = new System.Drawing.Point(1061, 0);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.Size = new System.Drawing.Size(224, 635);
            this.panelRightSide.TabIndex = 1;
            // 
            // ucRightSide1
            // 
            this.ucRightSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRightSide1.Location = new System.Drawing.Point(0, 0);
            this.ucRightSide1.Name = "ucRightSide1";
            this.ucRightSide1.Size = new System.Drawing.Size(222, 633);
            this.ucRightSide1.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(275, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(786, 635);
            this.panelCenter.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 756);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Main Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.leftSidePanel.ResumeLayout(false);
            this.panelRightSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Panel topPanel;
        private UCLeftSide ucLeftSide1;
        private System.Windows.Forms.Panel panelRightSide;
        private System.Windows.Forms.Panel panelCenter;
        private UCRightSide ucRightSide1;
    }
}

