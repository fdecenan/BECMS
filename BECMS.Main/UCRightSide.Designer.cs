namespace BECMS.Main {
    partial class UCRightSide {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cLabelTitle1 = new FerPROJ.Design.Controls.CLabelTitle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.cLabelTitle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 834);
            this.panel1.TabIndex = 0;
            // 
            // cLabelTitle1
            // 
            this.cLabelTitle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cLabelTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLabelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cLabelTitle1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.cLabelTitle1.ForeColor = System.Drawing.SystemColors.Control;
            this.cLabelTitle1.Location = new System.Drawing.Point(0, 0);
            this.cLabelTitle1.Name = "cLabelTitle1";
            this.cLabelTitle1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.cLabelTitle1.Size = new System.Drawing.Size(275, 53);
            this.cLabelTitle1.TabIndex = 0;
            this.cLabelTitle1.Text = "REPORTS";
            this.cLabelTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCRightSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCRightSide";
            this.Size = new System.Drawing.Size(275, 834);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FerPROJ.Design.Controls.CLabelTitle cLabelTitle1;
    }
}
