namespace BECMS.Forms {
    partial class ManagePatientRecord {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label formIdLabel;
            System.Windows.Forms.Label dateCreatedStringLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label followUpDateLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.patientRecordModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formIdCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.nameCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.dateCreatedStringCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.descriptionCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.followUpDateCDateTimePickerKrypton = new FerPROJ.Design.Controls.CDateTimePickerKrypton();
            this.remarksCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientRecordItemModelCDatagridview = new FerPROJ.Design.Controls.CDatagridview();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreatmentPlanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientRecordItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cToolstripItems = new FerPROJ.Design.Controls.CToolstrip();
            this.linkLabelSelectPatient = new System.Windows.Forms.LinkLabel();
            formIdLabel = new System.Windows.Forms.Label();
            dateCreatedStringLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            followUpDateLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordItemModelCDatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordItemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(438, 1);
            // 
            // baseButtonUpdate
            // 
            this.baseButtonUpdate.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.FlatAppearance.BorderSize = 0;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            // 
            // PanelMain3
            // 
            this.PanelMain3.AutoScroll = true;
            this.PanelMain3.Controls.Add(this.linkLabelSelectPatient);
            this.PanelMain3.Controls.Add(this.panel1);
            this.PanelMain3.Controls.Add(remarksLabel);
            this.PanelMain3.Controls.Add(this.remarksCTextBoxKrypton);
            this.PanelMain3.Controls.Add(followUpDateLabel);
            this.PanelMain3.Controls.Add(this.followUpDateCDateTimePickerKrypton);
            this.PanelMain3.Controls.Add(descriptionLabel);
            this.PanelMain3.Controls.Add(this.descriptionCTextBoxKrypton);
            this.PanelMain3.Controls.Add(dateCreatedStringLabel);
            this.PanelMain3.Controls.Add(this.dateCreatedStringCTextBoxKrypton);
            this.PanelMain3.Controls.Add(this.nameCTextBoxKrypton);
            this.PanelMain3.Controls.Add(formIdLabel);
            this.PanelMain3.Controls.Add(this.formIdCTextBoxKrypton);
            this.PanelMain3.Size = new System.Drawing.Size(673, 540);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // panelMain1
            // 
            this.panelMain1.Size = new System.Drawing.Size(673, 73);
            // 
            // formIdLabel
            // 
            formIdLabel.AutoSize = true;
            formIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formIdLabel.Location = new System.Drawing.Point(22, 18);
            formIdLabel.Name = "formIdLabel";
            formIdLabel.Size = new System.Drawing.Size(68, 20);
            formIdLabel.TabIndex = 0;
            formIdLabel.Text = "Form Id:";
            // 
            // dateCreatedStringLabel
            // 
            dateCreatedStringLabel.AutoSize = true;
            dateCreatedStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateCreatedStringLabel.Location = new System.Drawing.Point(336, 190);
            dateCreatedStringLabel.Name = "dateCreatedStringLabel";
            dateCreatedStringLabel.Size = new System.Drawing.Size(155, 20);
            dateCreatedStringLabel.TabIndex = 4;
            dateCreatedStringLabel.Text = "Date Created String:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(21, 104);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // followUpDateLabel
            // 
            followUpDateLabel.AutoSize = true;
            followUpDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            followUpDateLabel.Location = new System.Drawing.Point(336, 104);
            followUpDateLabel.Name = "followUpDateLabel";
            followUpDateLabel.Size = new System.Drawing.Size(122, 20);
            followUpDateLabel.TabIndex = 8;
            followUpDateLabel.Text = "Follow Up Date:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarksLabel.Location = new System.Drawing.Point(22, 190);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(77, 20);
            remarksLabel.TabIndex = 12;
            remarksLabel.Text = "Remarks:";
            // 
            // patientRecordModelBindingSource
            // 
            this.patientRecordModelBindingSource.DataSource = typeof(BECMS.Models.PatientRecords.PatientRecordModel);
            // 
            // formIdCTextBoxKrypton
            // 
            this.formIdCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordModelBindingSource, "FormId", true));
            this.formIdCTextBoxKrypton.Location = new System.Drawing.Point(26, 41);
            this.formIdCTextBoxKrypton.Name = "formIdCTextBoxKrypton";
            this.formIdCTextBoxKrypton.Size = new System.Drawing.Size(269, 29);
            this.formIdCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.formIdCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.formIdCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formIdCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.formIdCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.formIdCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.formIdCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formIdCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.formIdCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.formIdCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.formIdCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formIdCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.formIdCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.formIdCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.formIdCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.formIdCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formIdCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.formIdCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.formIdCTextBoxKrypton.TabIndex = 1;
            this.formIdCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // nameCTextBoxKrypton
            // 
            this.nameCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordModelBindingSource, "Name", true));
            this.nameCTextBoxKrypton.Location = new System.Drawing.Point(340, 41);
            this.nameCTextBoxKrypton.Name = "nameCTextBoxKrypton";
            this.nameCTextBoxKrypton.Size = new System.Drawing.Size(306, 29);
            this.nameCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.nameCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.nameCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.nameCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.nameCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.nameCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.nameCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.nameCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.nameCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.nameCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.nameCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.nameCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.nameCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.nameCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.nameCTextBoxKrypton.TabIndex = 3;
            this.nameCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // dateCreatedStringCTextBoxKrypton
            // 
            this.dateCreatedStringCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordModelBindingSource, "DateCreatedString", true));
            this.dateCreatedStringCTextBoxKrypton.Location = new System.Drawing.Point(340, 213);
            this.dateCreatedStringCTextBoxKrypton.Name = "dateCreatedStringCTextBoxKrypton";
            this.dateCreatedStringCTextBoxKrypton.Size = new System.Drawing.Size(306, 29);
            this.dateCreatedStringCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dateCreatedStringCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.dateCreatedStringCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateCreatedStringCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.dateCreatedStringCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.dateCreatedStringCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dateCreatedStringCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateCreatedStringCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.dateCreatedStringCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.dateCreatedStringCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dateCreatedStringCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateCreatedStringCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.dateCreatedStringCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.dateCreatedStringCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dateCreatedStringCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.dateCreatedStringCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateCreatedStringCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.dateCreatedStringCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.dateCreatedStringCTextBoxKrypton.TabIndex = 5;
            this.dateCreatedStringCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // descriptionCTextBoxKrypton
            // 
            this.descriptionCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordModelBindingSource, "Description", true));
            this.descriptionCTextBoxKrypton.Location = new System.Drawing.Point(26, 130);
            this.descriptionCTextBoxKrypton.Name = "descriptionCTextBoxKrypton";
            this.descriptionCTextBoxKrypton.Size = new System.Drawing.Size(269, 29);
            this.descriptionCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.descriptionCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.descriptionCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.descriptionCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.descriptionCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.descriptionCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.descriptionCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.descriptionCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.descriptionCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.descriptionCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descriptionCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.descriptionCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.descriptionCTextBoxKrypton.TabIndex = 7;
            this.descriptionCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // followUpDateCDateTimePickerKrypton
            // 
            this.followUpDateCDateTimePickerKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientRecordModelBindingSource, "FollowUpDate", true));
            this.followUpDateCDateTimePickerKrypton.Location = new System.Drawing.Point(340, 130);
            this.followUpDateCDateTimePickerKrypton.Name = "followUpDateCDateTimePickerKrypton";
            this.followUpDateCDateTimePickerKrypton.Size = new System.Drawing.Size(306, 27);
            this.followUpDateCDateTimePickerKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.followUpDateCDateTimePickerKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.followUpDateCDateTimePickerKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.followUpDateCDateTimePickerKrypton.StateActive.Border.Rounding = 10;
            this.followUpDateCDateTimePickerKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.followUpDateCDateTimePickerKrypton.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.followUpDateCDateTimePickerKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.followUpDateCDateTimePickerKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.followUpDateCDateTimePickerKrypton.StateCommon.Border.Rounding = 10;
            this.followUpDateCDateTimePickerKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.followUpDateCDateTimePickerKrypton.StateNormal.Border.Color1 = System.Drawing.Color.DarkGray;
            this.followUpDateCDateTimePickerKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.followUpDateCDateTimePickerKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.followUpDateCDateTimePickerKrypton.TabIndex = 9;
            // 
            // remarksCTextBoxKrypton
            // 
            this.remarksCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordModelBindingSource, "Remarks", true));
            this.remarksCTextBoxKrypton.Location = new System.Drawing.Point(26, 213);
            this.remarksCTextBoxKrypton.Name = "remarksCTextBoxKrypton";
            this.remarksCTextBoxKrypton.Size = new System.Drawing.Size(269, 29);
            this.remarksCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.remarksCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remarksCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.remarksCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.remarksCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remarksCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.remarksCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.remarksCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remarksCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.remarksCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.remarksCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.remarksCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.remarksCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.remarksCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.remarksCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.remarksCTextBoxKrypton.TabIndex = 13;
            this.remarksCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.patientRecordItemModelCDatagridview);
            this.panel1.Controls.Add(this.cToolstripItems);
            this.panel1.Location = new System.Drawing.Point(25, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 263);
            this.panel1.TabIndex = 14;
            // 
            // patientRecordItemModelCDatagridview
            // 
            this.patientRecordItemModelCDatagridview.AllowUserToAddRows = false;
            this.patientRecordItemModelCDatagridview.AllowUserToDeleteRows = false;
            this.patientRecordItemModelCDatagridview.AllowUserToOrderColumns = true;
            this.patientRecordItemModelCDatagridview.AllowUserToResizeRows = false;
            this.patientRecordItemModelCDatagridview.AlternatingRowColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.patientRecordItemModelCDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.patientRecordItemModelCDatagridview.AutoGenerateColumns = false;
            this.patientRecordItemModelCDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientRecordItemModelCDatagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patientRecordItemModelCDatagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.patientRecordItemModelCDatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientRecordItemModelCDatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Custom;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientRecordItemModelCDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.patientRecordItemModelCDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRecordItemModelCDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DescriptionColumn,
            this.PrescriptionColumn,
            this.TreatmentPlanColumn});
            this.patientRecordItemModelCDatagridview.CustomHeaderFontStyle = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.patientRecordItemModelCDatagridview.CustomHeaderForeColor = System.Drawing.Color.Black;
            this.patientRecordItemModelCDatagridview.CustomRowFontStyle = new System.Drawing.Font("Tahoma", 8F);
            this.patientRecordItemModelCDatagridview.DataSource = this.patientRecordItemModelBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientRecordItemModelCDatagridview.DefaultCellStyle = dataGridViewCellStyle7;
            this.patientRecordItemModelCDatagridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patientRecordItemModelCDatagridview.EnableHeadersVisualStyles = false;
            this.patientRecordItemModelCDatagridview.HeaderColor = System.Drawing.Color.WhiteSmoke;
            this.patientRecordItemModelCDatagridview.Location = new System.Drawing.Point(0, 28);
            this.patientRecordItemModelCDatagridview.Name = "patientRecordItemModelCDatagridview";
            this.patientRecordItemModelCDatagridview.ReadOnly = true;
            this.patientRecordItemModelCDatagridview.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientRecordItemModelCDatagridview.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.patientRecordItemModelCDatagridview.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.patientRecordItemModelCDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientRecordItemModelCDatagridview.Size = new System.Drawing.Size(620, 233);
            this.patientRecordItemModelCDatagridview.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "Description";
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // PrescriptionColumn
            // 
            this.PrescriptionColumn.DataPropertyName = "Prescription";
            this.PrescriptionColumn.HeaderText = "Prescription";
            this.PrescriptionColumn.Name = "PrescriptionColumn";
            this.PrescriptionColumn.ReadOnly = true;
            // 
            // TreatmentPlanColumn
            // 
            this.TreatmentPlanColumn.DataPropertyName = "TreatmentPlan";
            this.TreatmentPlanColumn.HeaderText = "TreatmentPlan";
            this.TreatmentPlanColumn.Name = "TreatmentPlanColumn";
            this.TreatmentPlanColumn.ReadOnly = true;
            // 
            // patientRecordItemModelBindingSource
            // 
            this.patientRecordItemModelBindingSource.DataSource = typeof(BECMS.Models.PatientRecords.PatientRecordItemModel);
            // 
            // cToolstripItems
            // 
            this.cToolstripItems.AutoSize = false;
            this.cToolstripItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cToolstripItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cToolstripItems.Location = new System.Drawing.Point(0, 0);
            this.cToolstripItems.Name = "cToolstripItems";
            this.cToolstripItems.Size = new System.Drawing.Size(620, 25);
            this.cToolstripItems.TabIndex = 0;
            this.cToolstripItems.Text = "cToolstrip1";
            // 
            // linkLabelSelectPatient
            // 
            this.linkLabelSelectPatient.AutoSize = true;
            this.linkLabelSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSelectPatient.Location = new System.Drawing.Point(340, 18);
            this.linkLabelSelectPatient.Name = "linkLabelSelectPatient";
            this.linkLabelSelectPatient.Size = new System.Drawing.Size(112, 20);
            this.linkLabelSelectPatient.TabIndex = 15;
            this.linkLabelSelectPatient.TabStop = true;
            this.linkLabelSelectPatient.Text = "Select Patient:";
            this.linkLabelSelectPatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectPatient_LinkClicked);
            // 
            // ManagePatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 698);
            this.CurrentFormMode = FerPROJ.Design.Forms.FrmManageKrypton.FormMode.Add;
            this.Name = "ManagePatientRecord";
            this.Text = "ManagePatientRecord";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordItemModelCDatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordItemModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CTextBoxKrypton dateCreatedStringCTextBoxKrypton;
        private System.Windows.Forms.BindingSource patientRecordModelBindingSource;
        private FerPROJ.Design.Controls.CTextBoxKrypton nameCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton formIdCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton remarksCTextBoxKrypton;
        private FerPROJ.Design.Controls.CDateTimePickerKrypton followUpDateCDateTimePickerKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton descriptionCTextBoxKrypton;
        private System.Windows.Forms.Panel panel1;
        private FerPROJ.Design.Controls.CDatagridview patientRecordItemModelCDatagridview;
        private System.Windows.Forms.BindingSource patientRecordItemModelBindingSource;
        private FerPROJ.Design.Controls.CToolstrip cToolstripItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreatmentPlanColumn;
        private System.Windows.Forms.LinkLabel linkLabelSelectPatient;
    }
}