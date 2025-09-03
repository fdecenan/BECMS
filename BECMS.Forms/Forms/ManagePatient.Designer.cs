namespace BECMS.Forms.Forms {
    partial class ManagePatient {
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label patientStatusLabel;
            System.Windows.Forms.Label patientAddressLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label contactNumberLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label referredByLabel;
            System.Windows.Forms.Label dateCreatedStringLabel;
            this.patientModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.middleNameCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.lastNameCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.ageCNumericUpDownKrypton = new FerPROJ.Design.Controls.CNumericUpDownKrypton();
            this.genderCComboBoxKrypton = new FerPROJ.Design.Controls.CComboBoxKrypton();
            this.patientStatusCComboBoxKrypton = new FerPROJ.Design.Controls.CComboBoxKrypton();
            this.patientAddressCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.birthdateCDateTimePickerKrypton = new FerPROJ.Design.Controls.CDateTimePickerKrypton();
            this.contactNumberCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.occupationCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.referredByCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            this.dateCreatedStringCTextBoxKrypton = new FerPROJ.Design.Controls.CTextBoxKrypton();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            patientStatusLabel = new System.Windows.Forms.Label();
            patientAddressLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            referredByLabel = new System.Windows.Forms.Label();
            dateCreatedStringLabel = new System.Windows.Forms.Label();
            this.basePnl2.SuspendLayout();
            this.PanelMain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderCComboBoxKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientStatusCComboBoxKrypton)).BeginInit();
            this.SuspendLayout();
            // 
            // basePnl2
            // 
            this.basePnl2.Location = new System.Drawing.Point(686, 1);
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
            this.PanelMain3.Controls.Add(dateCreatedStringLabel);
            this.PanelMain3.Controls.Add(this.dateCreatedStringCTextBoxKrypton);
            this.PanelMain3.Controls.Add(referredByLabel);
            this.PanelMain3.Controls.Add(this.referredByCTextBoxKrypton);
            this.PanelMain3.Controls.Add(occupationLabel);
            this.PanelMain3.Controls.Add(this.occupationCTextBoxKrypton);
            this.PanelMain3.Controls.Add(contactNumberLabel);
            this.PanelMain3.Controls.Add(this.contactNumberCTextBoxKrypton);
            this.PanelMain3.Controls.Add(birthdateLabel);
            this.PanelMain3.Controls.Add(this.birthdateCDateTimePickerKrypton);
            this.PanelMain3.Controls.Add(patientAddressLabel);
            this.PanelMain3.Controls.Add(this.patientAddressCTextBoxKrypton);
            this.PanelMain3.Controls.Add(patientStatusLabel);
            this.PanelMain3.Controls.Add(this.patientStatusCComboBoxKrypton);
            this.PanelMain3.Controls.Add(genderLabel);
            this.PanelMain3.Controls.Add(this.genderCComboBoxKrypton);
            this.PanelMain3.Controls.Add(ageLabel);
            this.PanelMain3.Controls.Add(this.ageCNumericUpDownKrypton);
            this.PanelMain3.Controls.Add(lastNameLabel);
            this.PanelMain3.Controls.Add(this.lastNameCTextBoxKrypton);
            this.PanelMain3.Controls.Add(middleNameLabel);
            this.PanelMain3.Controls.Add(this.middleNameCTextBoxKrypton);
            this.PanelMain3.Controls.Add(firstNameLabel);
            this.PanelMain3.Controls.Add(this.firstNameCTextBoxKrypton);
            this.PanelMain3.Size = new System.Drawing.Size(921, 435);
            // 
            // baseButtonAddNew
            // 
            this.baseButtonAddNew.FlatAppearance.BorderSize = 0;
            // 
            // panelMain1
            // 
            this.panelMain1.Size = new System.Drawing.Size(921, 73);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(41, 32);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            middleNameLabel.Location = new System.Drawing.Point(310, 32);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(105, 20);
            middleNameLabel.TabIndex = 2;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(608, 32);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(310, 121);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(42, 20);
            ageLabel.TabIndex = 8;
            ageLabel.Text = "Age:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(310, 224);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 14;
            genderLabel.Text = "Gender:";
            // 
            // patientStatusLabel
            // 
            patientStatusLabel.AutoSize = true;
            patientStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientStatusLabel.Location = new System.Drawing.Point(608, 121);
            patientStatusLabel.Name = "patientStatusLabel";
            patientStatusLabel.Size = new System.Drawing.Size(114, 20);
            patientStatusLabel.TabIndex = 10;
            patientStatusLabel.Text = "Patient Status:";
            // 
            // patientAddressLabel
            // 
            patientAddressLabel.AutoSize = true;
            patientAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientAddressLabel.Location = new System.Drawing.Point(41, 224);
            patientAddressLabel.Name = "patientAddressLabel";
            patientAddressLabel.Size = new System.Drawing.Size(126, 20);
            patientAddressLabel.TabIndex = 12;
            patientAddressLabel.Text = "Patient Address:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdateLabel.Location = new System.Drawing.Point(41, 121);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(78, 20);
            birthdateLabel.TabIndex = 6;
            birthdateLabel.Text = "Birthdate:";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactNumberLabel.Location = new System.Drawing.Point(608, 224);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(129, 20);
            contactNumberLabel.TabIndex = 16;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            occupationLabel.Location = new System.Drawing.Point(41, 331);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(94, 20);
            occupationLabel.TabIndex = 18;
            occupationLabel.Text = "Occupation:";
            // 
            // referredByLabel
            // 
            referredByLabel.AutoSize = true;
            referredByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            referredByLabel.Location = new System.Drawing.Point(310, 331);
            referredByLabel.Name = "referredByLabel";
            referredByLabel.Size = new System.Drawing.Size(98, 20);
            referredByLabel.TabIndex = 20;
            referredByLabel.Text = "Referred By:";
            // 
            // dateCreatedStringLabel
            // 
            dateCreatedStringLabel.AutoSize = true;
            dateCreatedStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateCreatedStringLabel.Location = new System.Drawing.Point(608, 331);
            dateCreatedStringLabel.Name = "dateCreatedStringLabel";
            dateCreatedStringLabel.Size = new System.Drawing.Size(155, 20);
            dateCreatedStringLabel.TabIndex = 22;
            dateCreatedStringLabel.Text = "Date Created String:";
            // 
            // patientModelBindingSource
            // 
            this.patientModelBindingSource.DataSource = typeof(BECMS.Models.Patients.PatientModel);
            // 
            // firstNameCTextBoxKrypton
            // 
            this.firstNameCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "FirstName", true));
            this.firstNameCTextBoxKrypton.Location = new System.Drawing.Point(44, 65);
            this.firstNameCTextBoxKrypton.Name = "firstNameCTextBoxKrypton";
            this.firstNameCTextBoxKrypton.Size = new System.Drawing.Size(216, 29);
            this.firstNameCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.firstNameCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.firstNameCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.firstNameCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.firstNameCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.firstNameCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.firstNameCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.firstNameCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.firstNameCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.firstNameCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.firstNameCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.firstNameCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.firstNameCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstNameCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.firstNameCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.firstNameCTextBoxKrypton.TabIndex = 1;
            this.firstNameCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // middleNameCTextBoxKrypton
            // 
            this.middleNameCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "MiddleName", true));
            this.middleNameCTextBoxKrypton.Location = new System.Drawing.Point(313, 65);
            this.middleNameCTextBoxKrypton.Name = "middleNameCTextBoxKrypton";
            this.middleNameCTextBoxKrypton.Size = new System.Drawing.Size(230, 29);
            this.middleNameCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.middleNameCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.middleNameCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.middleNameCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.middleNameCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.middleNameCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.middleNameCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.middleNameCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.middleNameCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.middleNameCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.middleNameCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.middleNameCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.middleNameCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.middleNameCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.middleNameCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.middleNameCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.middleNameCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.middleNameCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.middleNameCTextBoxKrypton.TabIndex = 3;
            this.middleNameCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // lastNameCTextBoxKrypton
            // 
            this.lastNameCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "LastName", true));
            this.lastNameCTextBoxKrypton.Location = new System.Drawing.Point(611, 65);
            this.lastNameCTextBoxKrypton.Name = "lastNameCTextBoxKrypton";
            this.lastNameCTextBoxKrypton.Size = new System.Drawing.Size(258, 29);
            this.lastNameCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.lastNameCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.lastNameCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.lastNameCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.lastNameCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.lastNameCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.lastNameCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.lastNameCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.lastNameCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.lastNameCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.lastNameCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.lastNameCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.lastNameCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.lastNameCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.lastNameCTextBoxKrypton.TabIndex = 5;
            this.lastNameCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // ageCNumericUpDownKrypton
            // 
            this.ageCNumericUpDownKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientModelBindingSource, "Age", true));
            this.ageCNumericUpDownKrypton.Enabled = false;
            this.ageCNumericUpDownKrypton.Location = new System.Drawing.Point(313, 150);
            this.ageCNumericUpDownKrypton.Name = "ageCNumericUpDownKrypton";
            this.ageCNumericUpDownKrypton.Size = new System.Drawing.Size(230, 28);
            this.ageCNumericUpDownKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.ageCNumericUpDownKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.ageCNumericUpDownKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageCNumericUpDownKrypton.StateActive.Border.Rounding = 10;
            this.ageCNumericUpDownKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.ageCNumericUpDownKrypton.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.ageCNumericUpDownKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.ageCNumericUpDownKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageCNumericUpDownKrypton.StateCommon.Border.Rounding = 10;
            this.ageCNumericUpDownKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ageCNumericUpDownKrypton.StateNormal.Border.Color1 = System.Drawing.Color.DarkGray;
            this.ageCNumericUpDownKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.ageCNumericUpDownKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageCNumericUpDownKrypton.TabIndex = 9;
            // 
            // genderCComboBoxKrypton
            // 
            this.genderCComboBoxKrypton.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.genderCComboBoxKrypton.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genderCComboBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "Gender", true));
            this.genderCComboBoxKrypton.DropDownWidth = 115;
            this.genderCComboBoxKrypton.Location = new System.Drawing.Point(314, 257);
            this.genderCComboBoxKrypton.Name = "genderCComboBoxKrypton";
            this.genderCComboBoxKrypton.Size = new System.Drawing.Size(230, 27);
            this.genderCComboBoxKrypton.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.DarkGray;
            this.genderCComboBoxKrypton.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.genderCComboBoxKrypton.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genderCComboBoxKrypton.StateActive.ComboBox.Border.Rounding = 10;
            this.genderCComboBoxKrypton.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.genderCComboBoxKrypton.StateDisabled.ComboBox.Border.Color1 = System.Drawing.Color.DarkGray;
            this.genderCComboBoxKrypton.StateDisabled.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.genderCComboBoxKrypton.StateDisabled.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genderCComboBoxKrypton.StateDisabled.ComboBox.Border.Rounding = 10;
            this.genderCComboBoxKrypton.StateDisabled.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.genderCComboBoxKrypton.TabIndex = 15;
            this.genderCComboBoxKrypton.Text = "cComboBoxKrypton1";
            // 
            // patientStatusCComboBoxKrypton
            // 
            this.patientStatusCComboBoxKrypton.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.patientStatusCComboBoxKrypton.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patientStatusCComboBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "PatientStatus", true));
            this.patientStatusCComboBoxKrypton.DropDownWidth = 115;
            this.patientStatusCComboBoxKrypton.Location = new System.Drawing.Point(611, 150);
            this.patientStatusCComboBoxKrypton.Name = "patientStatusCComboBoxKrypton";
            this.patientStatusCComboBoxKrypton.Size = new System.Drawing.Size(258, 27);
            this.patientStatusCComboBoxKrypton.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.DarkGray;
            this.patientStatusCComboBoxKrypton.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.patientStatusCComboBoxKrypton.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.patientStatusCComboBoxKrypton.StateActive.ComboBox.Border.Rounding = 10;
            this.patientStatusCComboBoxKrypton.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.patientStatusCComboBoxKrypton.StateDisabled.ComboBox.Border.Color1 = System.Drawing.Color.DarkGray;
            this.patientStatusCComboBoxKrypton.StateDisabled.ComboBox.Border.Color2 = System.Drawing.Color.White;
            this.patientStatusCComboBoxKrypton.StateDisabled.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.patientStatusCComboBoxKrypton.StateDisabled.ComboBox.Border.Rounding = 10;
            this.patientStatusCComboBoxKrypton.StateDisabled.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.patientStatusCComboBoxKrypton.TabIndex = 11;
            this.patientStatusCComboBoxKrypton.Text = "cComboBoxKrypton1";
            // 
            // patientAddressCTextBoxKrypton
            // 
            this.patientAddressCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "PatientAddress", true));
            this.patientAddressCTextBoxKrypton.Location = new System.Drawing.Point(44, 256);
            this.patientAddressCTextBoxKrypton.Name = "patientAddressCTextBoxKrypton";
            this.patientAddressCTextBoxKrypton.Size = new System.Drawing.Size(216, 29);
            this.patientAddressCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.patientAddressCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.patientAddressCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.patientAddressCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.patientAddressCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.patientAddressCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.patientAddressCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.patientAddressCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.patientAddressCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.patientAddressCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.patientAddressCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.patientAddressCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.patientAddressCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.patientAddressCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.patientAddressCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.patientAddressCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.patientAddressCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.patientAddressCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.patientAddressCTextBoxKrypton.TabIndex = 13;
            this.patientAddressCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // birthdateCDateTimePickerKrypton
            // 
            this.birthdateCDateTimePickerKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientModelBindingSource, "Birthdate", true));
            this.birthdateCDateTimePickerKrypton.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateCDateTimePickerKrypton.Location = new System.Drawing.Point(44, 151);
            this.birthdateCDateTimePickerKrypton.Name = "birthdateCDateTimePickerKrypton";
            this.birthdateCDateTimePickerKrypton.ShowUpDown = true;
            this.birthdateCDateTimePickerKrypton.Size = new System.Drawing.Size(230, 27);
            this.birthdateCDateTimePickerKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.birthdateCDateTimePickerKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.birthdateCDateTimePickerKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.birthdateCDateTimePickerKrypton.StateActive.Border.Rounding = 10;
            this.birthdateCDateTimePickerKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.birthdateCDateTimePickerKrypton.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.birthdateCDateTimePickerKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.birthdateCDateTimePickerKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.birthdateCDateTimePickerKrypton.StateCommon.Border.Rounding = 10;
            this.birthdateCDateTimePickerKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.birthdateCDateTimePickerKrypton.StateNormal.Border.Color1 = System.Drawing.Color.DarkGray;
            this.birthdateCDateTimePickerKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.birthdateCDateTimePickerKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.birthdateCDateTimePickerKrypton.TabIndex = 7;
            // 
            // contactNumberCTextBoxKrypton
            // 
            this.contactNumberCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "ContactNumber", true));
            this.contactNumberCTextBoxKrypton.Location = new System.Drawing.Point(611, 256);
            this.contactNumberCTextBoxKrypton.Name = "contactNumberCTextBoxKrypton";
            this.contactNumberCTextBoxKrypton.Size = new System.Drawing.Size(258, 29);
            this.contactNumberCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.contactNumberCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.contactNumberCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactNumberCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.contactNumberCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.contactNumberCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.contactNumberCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactNumberCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.contactNumberCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.contactNumberCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.contactNumberCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactNumberCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.contactNumberCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.contactNumberCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.contactNumberCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.contactNumberCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contactNumberCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.contactNumberCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.contactNumberCTextBoxKrypton.TabIndex = 17;
            this.contactNumberCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // occupationCTextBoxKrypton
            // 
            this.occupationCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "Occupation", true));
            this.occupationCTextBoxKrypton.Location = new System.Drawing.Point(44, 361);
            this.occupationCTextBoxKrypton.Name = "occupationCTextBoxKrypton";
            this.occupationCTextBoxKrypton.Size = new System.Drawing.Size(216, 29);
            this.occupationCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.occupationCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.occupationCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.occupationCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.occupationCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.occupationCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.occupationCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.occupationCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.occupationCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.occupationCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.occupationCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.occupationCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.occupationCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.occupationCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.occupationCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.occupationCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.occupationCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.occupationCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.occupationCTextBoxKrypton.TabIndex = 19;
            this.occupationCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // referredByCTextBoxKrypton
            // 
            this.referredByCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "ReferredBy", true));
            this.referredByCTextBoxKrypton.Location = new System.Drawing.Point(313, 361);
            this.referredByCTextBoxKrypton.Name = "referredByCTextBoxKrypton";
            this.referredByCTextBoxKrypton.Size = new System.Drawing.Size(230, 29);
            this.referredByCTextBoxKrypton.StateActive.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.referredByCTextBoxKrypton.StateActive.Border.Color1 = System.Drawing.Color.DarkGray;
            this.referredByCTextBoxKrypton.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.referredByCTextBoxKrypton.StateActive.Border.Rounding = 10;
            this.referredByCTextBoxKrypton.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.referredByCTextBoxKrypton.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.referredByCTextBoxKrypton.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.referredByCTextBoxKrypton.StateCommon.Border.Rounding = 10;
            this.referredByCTextBoxKrypton.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.referredByCTextBoxKrypton.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.referredByCTextBoxKrypton.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.referredByCTextBoxKrypton.StateDisabled.Border.Rounding = 10;
            this.referredByCTextBoxKrypton.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.referredByCTextBoxKrypton.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.referredByCTextBoxKrypton.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.referredByCTextBoxKrypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.referredByCTextBoxKrypton.StateNormal.Border.Rounding = 10;
            this.referredByCTextBoxKrypton.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.referredByCTextBoxKrypton.TabIndex = 21;
            this.referredByCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // dateCreatedStringCTextBoxKrypton
            // 
            this.dateCreatedStringCTextBoxKrypton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientModelBindingSource, "DateCreatedString", true));
            this.dateCreatedStringCTextBoxKrypton.Location = new System.Drawing.Point(611, 361);
            this.dateCreatedStringCTextBoxKrypton.Name = "dateCreatedStringCTextBoxKrypton";
            this.dateCreatedStringCTextBoxKrypton.Size = new System.Drawing.Size(258, 29);
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
            this.dateCreatedStringCTextBoxKrypton.TabIndex = 23;
            this.dateCreatedStringCTextBoxKrypton.Text = "cTextBoxKrypton1";
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 593);
            this.CurrentFormMode = FerPROJ.Design.Forms.FrmManageKrypton.FormMode.Add;
            this.Name = "ManagePatient";
            this.Text = "ManagePatient";
            this.basePnl2.ResumeLayout(false);
            this.PanelMain3.ResumeLayout(false);
            this.PanelMain3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderCComboBoxKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientStatusCComboBoxKrypton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FerPROJ.Design.Controls.CDateTimePickerKrypton birthdateCDateTimePickerKrypton;
        private System.Windows.Forms.BindingSource patientModelBindingSource;
        private FerPROJ.Design.Controls.CTextBoxKrypton patientAddressCTextBoxKrypton;
        private FerPROJ.Design.Controls.CComboBoxKrypton patientStatusCComboBoxKrypton;
        private FerPROJ.Design.Controls.CComboBoxKrypton genderCComboBoxKrypton;
        private FerPROJ.Design.Controls.CNumericUpDownKrypton ageCNumericUpDownKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton lastNameCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton middleNameCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton firstNameCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton dateCreatedStringCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton referredByCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton occupationCTextBoxKrypton;
        private FerPROJ.Design.Controls.CTextBoxKrypton contactNumberCTextBoxKrypton;
    }
}