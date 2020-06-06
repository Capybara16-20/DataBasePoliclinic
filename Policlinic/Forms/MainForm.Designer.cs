namespace Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.patientsGrid = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCards = new System.Windows.Forms.TabPage();
            this.searchCardGridView = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShelving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCardButton = new System.Windows.Forms.Button();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCoupons = new System.Windows.Forms.TabPage();
            this.listGetCouponMessage = new System.Windows.Forms.ListBox();
            this.labelPolicy = new System.Windows.Forms.Label();
            this.textPolicy = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.freeCouponsGridView = new System.Windows.Forms.DataGridView();
            this.columnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGetCoupon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboDoctor = new System.Windows.Forms.ComboBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.comboTreatmentType = new System.Windows.Forms.ComboBox();
            this.labelTreatmentType = new System.Windows.Forms.Label();
            this.labelReceptionCategory = new System.Windows.Forms.Label();
            this.comboReceptionCategory = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPrintDate = new System.Windows.Forms.Button();
            this.buttonCouponDate = new System.Windows.Forms.Button();
            this.gridCouponDate = new System.Windows.Forms.DataGridView();
            this.ColumnTreatmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDoctor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelAfter = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridCouponDoctor = new System.Windows.Forms.DataGridView();
            this.ColumnTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatient1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDoctor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpecialty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelect1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelDoctor2 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.поликлиникаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поликлиникаDataSet = new Forms.ПоликлиникаDataSet();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorShowCoupon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGetCoupon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCouponDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCouponDoctor = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridCouponSpecialty = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.buttonPrintCouponDoctor = new System.Windows.Forms.Button();
            this.buttonSeleceCoupon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.errorProviderCouponSpecialty = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelectCoupon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonPrintCoupon = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCardGridView)).BeginInit();
            this.tabCoupons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeCouponsGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCouponDate)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCouponDoctor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShowCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGetCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCouponDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCouponDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCouponSpecialty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCouponSpecialty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRegistration);
            this.tabControl.Controls.Add(this.tabCards);
            this.tabControl.Controls.Add(this.tabCoupons);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabRegistration.Controls.Add(this.patientsGrid);
            this.tabRegistration.Controls.Add(this.menuStrip1);
            this.tabRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(780, 424);
            this.tabRegistration.TabIndex = 0;
            this.tabRegistration.Text = "Пациенты";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // patientsGrid
            // 
            this.patientsGrid.AllowUserToAddRows = false;
            this.patientsGrid.AllowUserToDeleteRows = false;
            this.patientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.txtName,
            this.Patronymic,
            this.Policy,
            this.Birthdate,
            this.Gender,
            this.Address});
            this.patientsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientsGrid.Location = new System.Drawing.Point(3, 27);
            this.patientsGrid.Name = "patientsGrid";
            this.patientsGrid.ReadOnly = true;
            this.patientsGrid.Size = new System.Drawing.Size(774, 394);
            this.patientsGrid.TabIndex = 1;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.HeaderText = "Имя";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // Policy
            // 
            this.Policy.HeaderText = "Полис ОМС";
            this.Policy.Name = "Policy";
            this.Policy.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Дата рождения";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // tabCards
            // 
            this.tabCards.Controls.Add(this.searchCardGridView);
            this.tabCards.Controls.Add(this.searchCardButton);
            this.tabCards.Controls.Add(this.textYear);
            this.tabCards.Controls.Add(this.label3);
            this.tabCards.Controls.Add(this.textAddress);
            this.tabCards.Controls.Add(this.label2);
            this.tabCards.Controls.Add(this.textSurname);
            this.tabCards.Controls.Add(this.label1);
            this.tabCards.Location = new System.Drawing.Point(4, 22);
            this.tabCards.Name = "tabCards";
            this.tabCards.Padding = new System.Windows.Forms.Padding(3);
            this.tabCards.Size = new System.Drawing.Size(780, 424);
            this.tabCards.TabIndex = 1;
            this.tabCards.Text = "Карты";
            this.tabCards.UseVisualStyleBackColor = true;
            // 
            // searchCardGridView
            // 
            this.searchCardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCardGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnPatronymic,
            this.txtSurname,
            this.columnBirthdate,
            this.columnAddress,
            this.columnShelving,
            this.columnShelf});
            this.searchCardGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchCardGridView.Location = new System.Drawing.Point(3, 113);
            this.searchCardGridView.Name = "searchCardGridView";
            this.searchCardGridView.Size = new System.Drawing.Size(774, 308);
            this.searchCardGridView.TabIndex = 7;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Имя";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnPatronymic
            // 
            this.columnPatronymic.HeaderText = "Отчество";
            this.columnPatronymic.Name = "columnPatronymic";
            this.columnPatronymic.ReadOnly = true;
            // 
            // txtSurname
            // 
            this.txtSurname.HeaderText = "Фамилия";
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            // 
            // columnBirthdate
            // 
            this.columnBirthdate.HeaderText = "Дата рождения";
            this.columnBirthdate.Name = "columnBirthdate";
            this.columnBirthdate.ReadOnly = true;
            // 
            // columnAddress
            // 
            this.columnAddress.HeaderText = "Адрес";
            this.columnAddress.Name = "columnAddress";
            this.columnAddress.ReadOnly = true;
            // 
            // columnShelving
            // 
            this.columnShelving.HeaderText = "Номер стеллажа";
            this.columnShelving.Name = "columnShelving";
            this.columnShelving.ReadOnly = true;
            // 
            // columnShelf
            // 
            this.columnShelf.HeaderText = "Номер полки";
            this.columnShelf.Name = "columnShelf";
            this.columnShelf.ReadOnly = true;
            // 
            // searchCardButton
            // 
            this.searchCardButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.searchCardButton.Location = new System.Drawing.Point(280, 84);
            this.searchCardButton.Name = "searchCardButton";
            this.searchCardButton.Size = new System.Drawing.Size(218, 23);
            this.searchCardButton.TabIndex = 6;
            this.searchCardButton.Text = "Поиск карты";
            this.searchCardButton.UseVisualStyleBackColor = false;
            this.searchCardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(366, 32);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(132, 20);
            this.textYear.TabIndex = 5;
            this.textYear.Validating += new System.ComponentModel.CancelEventHandler(this.textYear_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год рождения";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(366, 58);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(132, 20);
            this.textAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(366, 6);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(132, 20);
            this.textSurname.TabIndex = 1;
            this.textSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // tabCoupons
            // 
            this.tabCoupons.Controls.Add(this.buttonPrintCoupon);
            this.tabCoupons.Controls.Add(this.listGetCouponMessage);
            this.tabCoupons.Controls.Add(this.labelPolicy);
            this.tabCoupons.Controls.Add(this.textPolicy);
            this.tabCoupons.Controls.Add(this.labelDate);
            this.tabCoupons.Controls.Add(this.dateTimePicker1);
            this.tabCoupons.Controls.Add(this.button2);
            this.tabCoupons.Controls.Add(this.freeCouponsGridView);
            this.tabCoupons.Controls.Add(this.button1);
            this.tabCoupons.Controls.Add(this.comboDoctor);
            this.tabCoupons.Controls.Add(this.labelDoctor);
            this.tabCoupons.Controls.Add(this.comboTreatmentType);
            this.tabCoupons.Controls.Add(this.labelTreatmentType);
            this.tabCoupons.Controls.Add(this.labelReceptionCategory);
            this.tabCoupons.Controls.Add(this.comboReceptionCategory);
            this.tabCoupons.Location = new System.Drawing.Point(4, 22);
            this.tabCoupons.Name = "tabCoupons";
            this.tabCoupons.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoupons.Size = new System.Drawing.Size(780, 424);
            this.tabCoupons.TabIndex = 2;
            this.tabCoupons.Text = "Талоны";
            this.tabCoupons.UseVisualStyleBackColor = true;
            // 
            // listGetCouponMessage
            // 
            this.listGetCouponMessage.FormattingEnabled = true;
            this.listGetCouponMessage.Location = new System.Drawing.Point(3, 3);
            this.listGetCouponMessage.Name = "listGetCouponMessage";
            this.listGetCouponMessage.Size = new System.Drawing.Size(338, 134);
            this.listGetCouponMessage.TabIndex = 14;
            // 
            // labelPolicy
            // 
            this.labelPolicy.AutoSize = true;
            this.labelPolicy.Location = new System.Drawing.Point(683, 9);
            this.labelPolicy.Name = "labelPolicy";
            this.labelPolicy.Size = new System.Drawing.Size(66, 13);
            this.labelPolicy.TabIndex = 13;
            this.labelPolicy.Text = "Полис ОМС";
            // 
            // textPolicy
            // 
            this.textPolicy.Location = new System.Drawing.Point(660, 34);
            this.textPolicy.Name = "textPolicy";
            this.textPolicy.Size = new System.Drawing.Size(110, 20);
            this.textPolicy.TabIndex = 12;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(347, 87);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Location = new System.Drawing.Point(660, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Выписать талон";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // freeCouponsGridView
            // 
            this.freeCouponsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freeCouponsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCategory,
            this.columnType,
            this.columnDoctor,
            this.columnDate,
            this.columnTime,
            this.columnGetCoupon});
            this.freeCouponsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.freeCouponsGridView.Enabled = false;
            this.freeCouponsGridView.Location = new System.Drawing.Point(3, 142);
            this.freeCouponsGridView.Name = "freeCouponsGridView";
            this.freeCouponsGridView.Size = new System.Drawing.Size(774, 279);
            this.freeCouponsGridView.TabIndex = 7;
            // 
            // columnCategory
            // 
            this.columnCategory.HeaderText = "Категория";
            this.columnCategory.Name = "columnCategory";
            this.columnCategory.ReadOnly = true;
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Тип обращения";
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            // 
            // columnDoctor
            // 
            this.columnDoctor.HeaderText = "Врач";
            this.columnDoctor.Name = "columnDoctor";
            this.columnDoctor.ReadOnly = true;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Дата приёма";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // columnTime
            // 
            this.columnTime.HeaderText = "Время приёма";
            this.columnTime.Name = "columnTime";
            this.columnTime.ReadOnly = true;
            // 
            // columnGetCoupon
            // 
            this.columnGetCoupon.HeaderText = "Выбрать талон";
            this.columnGetCoupon.Name = "columnGetCoupon";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(350, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Показать свободные талоны";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboDoctor
            // 
            this.comboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoctor.FormattingEnabled = true;
            this.comboDoctor.Location = new System.Drawing.Point(454, 60);
            this.comboDoctor.Name = "comboDoctor";
            this.comboDoctor.Size = new System.Drawing.Size(200, 21);
            this.comboDoctor.TabIndex = 5;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(347, 63);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(31, 13);
            this.labelDoctor.TabIndex = 4;
            this.labelDoctor.Text = "Врач";
            // 
            // comboTreatmentType
            // 
            this.comboTreatmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTreatmentType.FormattingEnabled = true;
            this.comboTreatmentType.Location = new System.Drawing.Point(454, 33);
            this.comboTreatmentType.Name = "comboTreatmentType";
            this.comboTreatmentType.Size = new System.Drawing.Size(200, 21);
            this.comboTreatmentType.TabIndex = 3;
            this.comboTreatmentType.SelectedIndexChanged += new System.EventHandler(this.comboTreatmentType_SelectedIndexChanged);
            // 
            // labelTreatmentType
            // 
            this.labelTreatmentType.AutoSize = true;
            this.labelTreatmentType.Location = new System.Drawing.Point(347, 36);
            this.labelTreatmentType.Name = "labelTreatmentType";
            this.labelTreatmentType.Size = new System.Drawing.Size(86, 13);
            this.labelTreatmentType.TabIndex = 2;
            this.labelTreatmentType.Text = "Тип обращения";
            // 
            // labelReceptionCategory
            // 
            this.labelReceptionCategory.AutoSize = true;
            this.labelReceptionCategory.Location = new System.Drawing.Point(347, 9);
            this.labelReceptionCategory.Name = "labelReceptionCategory";
            this.labelReceptionCategory.Size = new System.Drawing.Size(101, 13);
            this.labelReceptionCategory.TabIndex = 1;
            this.labelReceptionCategory.Text = "Категория приёма";
            // 
            // comboReceptionCategory
            // 
            this.comboReceptionCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReceptionCategory.FormattingEnabled = true;
            this.comboReceptionCategory.Location = new System.Drawing.Point(454, 6);
            this.comboReceptionCategory.Name = "comboReceptionCategory";
            this.comboReceptionCategory.Size = new System.Drawing.Size(200, 21);
            this.comboReceptionCategory.TabIndex = 0;
            this.comboReceptionCategory.SelectedIndexChanged += new System.EventHandler(this.comboReceptionCategory_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPrintDate);
            this.tabPage1.Controls.Add(this.buttonCouponDate);
            this.tabPage1.Controls.Add(this.gridCouponDate);
            this.tabPage1.Controls.Add(this.labelBefore);
            this.tabPage1.Controls.Add(this.labelAfter);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.labelPeriod);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 424);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Печать талона - Дата";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonPrintDate
            // 
            this.buttonPrintDate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrintDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPrintDate.Location = new System.Drawing.Point(461, 23);
            this.buttonPrintDate.Name = "buttonPrintDate";
            this.buttonPrintDate.Size = new System.Drawing.Size(108, 75);
            this.buttonPrintDate.TabIndex = 7;
            this.buttonPrintDate.Text = "Печать";
            this.buttonPrintDate.UseVisualStyleBackColor = false;
            this.buttonPrintDate.Click += new System.EventHandler(this.buttonPrintDate_Click);
            // 
            // buttonCouponDate
            // 
            this.buttonCouponDate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCouponDate.Location = new System.Drawing.Point(230, 75);
            this.buttonCouponDate.Name = "buttonCouponDate";
            this.buttonCouponDate.Size = new System.Drawing.Size(225, 23);
            this.buttonCouponDate.TabIndex = 6;
            this.buttonCouponDate.Text = "Вывести талоны";
            this.buttonCouponDate.UseVisualStyleBackColor = false;
            this.buttonCouponDate.Click += new System.EventHandler(this.buttonCouponDate_Click);
            // 
            // gridCouponDate
            // 
            this.gridCouponDate.AllowUserToAddRows = false;
            this.gridCouponDate.AllowUserToDeleteRows = false;
            this.gridCouponDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCouponDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTreatmentType,
            this.ColumnPatient,
            this.ColumnDoctor1,
            this.ColumnSpecialty,
            this.ColumnDate1,
            this.ColumnTime1,
            this.ColumnSelect});
            this.gridCouponDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCouponDate.Location = new System.Drawing.Point(3, 104);
            this.gridCouponDate.Name = "gridCouponDate";
            this.gridCouponDate.Size = new System.Drawing.Size(774, 317);
            this.gridCouponDate.TabIndex = 5;
            // 
            // ColumnTreatmentType
            // 
            this.ColumnTreatmentType.HeaderText = "Тип обращения";
            this.ColumnTreatmentType.Name = "ColumnTreatmentType";
            this.ColumnTreatmentType.ReadOnly = true;
            // 
            // ColumnPatient
            // 
            this.ColumnPatient.HeaderText = "ФИО пациента";
            this.ColumnPatient.Name = "ColumnPatient";
            this.ColumnPatient.ReadOnly = true;
            // 
            // ColumnDoctor1
            // 
            this.ColumnDoctor1.HeaderText = "ФИО врача";
            this.ColumnDoctor1.Name = "ColumnDoctor1";
            this.ColumnDoctor1.ReadOnly = true;
            // 
            // ColumnSpecialty
            // 
            this.ColumnSpecialty.HeaderText = "Специализация врача";
            this.ColumnSpecialty.Name = "ColumnSpecialty";
            this.ColumnSpecialty.ReadOnly = true;
            // 
            // ColumnDate1
            // 
            this.ColumnDate1.HeaderText = "Дата приёма";
            this.ColumnDate1.Name = "ColumnDate1";
            this.ColumnDate1.ReadOnly = true;
            // 
            // ColumnTime1
            // 
            this.ColumnTime1.HeaderText = "Время талона";
            this.ColumnTime1.Name = "ColumnTime1";
            this.ColumnTime1.ReadOnly = true;
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.HeaderText = "Выбрать талон";
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.ReadOnly = true;
            this.ColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.Location = new System.Drawing.Point(227, 56);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(22, 13);
            this.labelBefore.TabIndex = 4;
            this.labelBefore.Text = "До";
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(227, 30);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(14, 13);
            this.labelAfter.TabIndex = 3;
            this.labelAfter.Text = "С";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(255, 49);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPeriod.Location = new System.Drawing.Point(313, 3);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(58, 17);
            this.labelPeriod.TabIndex = 1;
            this.labelPeriod.Text = "Период";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(255, 23);
            this.dateTimePicker2.MaxDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridCouponDoctor);
            this.tabPage2.Controls.Add(this.labelDoctor2);
            this.tabPage2.Controls.Add(this.comboBoxDoctor);
            this.tabPage2.Controls.Add(this.buttonPrint);
            this.tabPage2.Controls.Add(this.buttonSelect);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePicker4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dateTimePicker5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 424);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Печать талона - Врач";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridCouponDoctor
            // 
            this.gridCouponDoctor.AllowUserToAddRows = false;
            this.gridCouponDoctor.AllowUserToDeleteRows = false;
            this.gridCouponDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCouponDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTreatment,
            this.ColumnPatient1,
            this.ColumnDoctor2,
            this.ColumnSpecialty1,
            this.ColumnDate2,
            this.ColumnTime2,
            this.ColumnSelect1});
            this.gridCouponDoctor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCouponDoctor.Location = new System.Drawing.Point(3, 130);
            this.gridCouponDoctor.Name = "gridCouponDoctor";
            this.gridCouponDoctor.Size = new System.Drawing.Size(774, 291);
            this.gridCouponDoctor.TabIndex = 17;
            // 
            // ColumnTreatment
            // 
            this.ColumnTreatment.HeaderText = "Тип обращения";
            this.ColumnTreatment.Name = "ColumnTreatment";
            this.ColumnTreatment.ReadOnly = true;
            // 
            // ColumnPatient1
            // 
            this.ColumnPatient1.HeaderText = "ФИО пациента";
            this.ColumnPatient1.Name = "ColumnPatient1";
            this.ColumnPatient1.ReadOnly = true;
            // 
            // ColumnDoctor2
            // 
            this.ColumnDoctor2.HeaderText = "ФИО врача";
            this.ColumnDoctor2.Name = "ColumnDoctor2";
            this.ColumnDoctor2.ReadOnly = true;
            // 
            // ColumnSpecialty1
            // 
            this.ColumnSpecialty1.HeaderText = "Специализация врача";
            this.ColumnSpecialty1.Name = "ColumnSpecialty1";
            this.ColumnSpecialty1.ReadOnly = true;
            // 
            // ColumnDate2
            // 
            this.ColumnDate2.HeaderText = "Дата приёма";
            this.ColumnDate2.Name = "ColumnDate2";
            this.ColumnDate2.ReadOnly = true;
            // 
            // ColumnTime2
            // 
            this.ColumnTime2.HeaderText = "Время талона";
            this.ColumnTime2.Name = "ColumnTime2";
            this.ColumnTime2.ReadOnly = true;
            // 
            // ColumnSelect1
            // 
            this.ColumnSelect1.HeaderText = "Выбрать талон";
            this.ColumnSelect1.Name = "ColumnSelect1";
            this.ColumnSelect1.ReadOnly = true;
            // 
            // labelDoctor2
            // 
            this.labelDoctor2.AutoSize = true;
            this.labelDoctor2.Location = new System.Drawing.Point(207, 77);
            this.labelDoctor2.Name = "labelDoctor2";
            this.labelDoctor2.Size = new System.Drawing.Size(31, 13);
            this.labelDoctor2.TabIndex = 16;
            this.labelDoctor2.Text = "Врач";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(244, 74);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDoctor.TabIndex = 15;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPrint.Location = new System.Drawing.Point(450, 23);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(108, 101);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSelect.Location = new System.Drawing.Point(210, 101);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(234, 23);
            this.buttonSelect.TabIndex = 13;
            this.buttonSelect.Text = "Вывести талоны";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "С";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(244, 48);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(306, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Период";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(244, 23);
            this.dateTimePicker5.MaxDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker5.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker5.TabIndex = 8;
            this.dateTimePicker5.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridCouponSpecialty);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.comboBoxSpecialty);
            this.tabPage3.Controls.Add(this.buttonPrintCouponDoctor);
            this.tabPage3.Controls.Add(this.buttonSeleceCoupon);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dateTimePicker6);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dateTimePicker7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 424);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Печать талона - Специальность";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // поликлиникаDataSetBindingSource
            // 
            this.поликлиникаDataSetBindingSource.DataSource = this.поликлиникаDataSet;
            this.поликлиникаDataSetBindingSource.Position = 0;
            // 
            // поликлиникаDataSet
            // 
            this.поликлиникаDataSet.DataSetName = "ПоликлиникаDataSet";
            this.поликлиникаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorShowCoupon
            // 
            this.errorShowCoupon.ContainerControl = this;
            // 
            // errorGetCoupon
            // 
            this.errorGetCoupon.ContainerControl = this;
            // 
            // errorProviderCouponDate
            // 
            this.errorProviderCouponDate.BlinkRate = 0;
            this.errorProviderCouponDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCouponDate.ContainerControl = this;
            // 
            // errorProviderCouponDoctor
            // 
            this.errorProviderCouponDoctor.BlinkRate = 0;
            this.errorProviderCouponDoctor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCouponDoctor.ContainerControl = this;
            // 
            // gridCouponSpecialty
            // 
            this.gridCouponSpecialty.AllowUserToAddRows = false;
            this.gridCouponSpecialty.AllowUserToDeleteRows = false;
            this.gridCouponSpecialty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCouponSpecialty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.ColumnSelectCoupon});
            this.gridCouponSpecialty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCouponSpecialty.Location = new System.Drawing.Point(3, 130);
            this.gridCouponSpecialty.Name = "gridCouponSpecialty";
            this.gridCouponSpecialty.Size = new System.Drawing.Size(774, 291);
            this.gridCouponSpecialty.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Специализация врача";
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.Location = new System.Drawing.Point(244, 74);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSpecialty.TabIndex = 25;
            // 
            // buttonPrintCouponDoctor
            // 
            this.buttonPrintCouponDoctor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrintCouponDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPrintCouponDoctor.Location = new System.Drawing.Point(450, 23);
            this.buttonPrintCouponDoctor.Name = "buttonPrintCouponDoctor";
            this.buttonPrintCouponDoctor.Size = new System.Drawing.Size(108, 101);
            this.buttonPrintCouponDoctor.TabIndex = 24;
            this.buttonPrintCouponDoctor.Text = "Печать";
            this.buttonPrintCouponDoctor.UseVisualStyleBackColor = false;
            this.buttonPrintCouponDoctor.Click += new System.EventHandler(this.buttonPrintCouponDoctor_Click);
            // 
            // buttonSeleceCoupon
            // 
            this.buttonSeleceCoupon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSeleceCoupon.Location = new System.Drawing.Point(210, 101);
            this.buttonSeleceCoupon.Name = "buttonSeleceCoupon";
            this.buttonSeleceCoupon.Size = new System.Drawing.Size(234, 23);
            this.buttonSeleceCoupon.TabIndex = 23;
            this.buttonSeleceCoupon.Text = "Вывести талоны";
            this.buttonSeleceCoupon.UseVisualStyleBackColor = false;
            this.buttonSeleceCoupon.Click += new System.EventHandler(this.buttonSeleceCoupon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "До";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "С";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(244, 48);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker6.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(306, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Период";
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.Location = new System.Drawing.Point(244, 23);
            this.dateTimePicker7.MaxDate = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker7.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker7.TabIndex = 18;
            this.dateTimePicker7.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // errorProviderCouponSpecialty
            // 
            this.errorProviderCouponSpecialty.BlinkRate = 0;
            this.errorProviderCouponSpecialty.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCouponSpecialty.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип обращения";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО пациента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО врача";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Специализация врача";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата приёма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Время талона";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ColumnSelectCoupon
            // 
            this.ColumnSelectCoupon.HeaderText = "Выбрать талон";
            this.ColumnSelectCoupon.Name = "ColumnSelectCoupon";
            this.ColumnSelectCoupon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSelectCoupon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonPrintCoupon
            // 
            this.buttonPrintCoupon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrintCoupon.Location = new System.Drawing.Point(660, 101);
            this.buttonPrintCoupon.Name = "buttonPrintCoupon";
            this.buttonPrintCoupon.Size = new System.Drawing.Size(110, 35);
            this.buttonPrintCoupon.TabIndex = 15;
            this.buttonPrintCoupon.Text = "Печать талона";
            this.buttonPrintCoupon.UseVisualStyleBackColor = false;
            this.buttonPrintCoupon.Click += new System.EventHandler(this.buttonPrintCoupon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистратура";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRegistration.ResumeLayout(false);
            this.tabRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCards.ResumeLayout(false);
            this.tabCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCardGridView)).EndInit();
            this.tabCoupons.ResumeLayout(false);
            this.tabCoupons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeCouponsGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCouponDate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCouponDoctor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShowCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGetCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCouponDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCouponDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCouponSpecialty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCouponSpecialty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabPage tabCards;
        private System.Windows.Forms.TabPage tabCoupons;
        private System.Windows.Forms.BindingSource поликлиникаDataSetBindingSource;
        private ПоликлиникаDataSet поликлиникаDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.DataGridView patientsGrid;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchCardGridView;
        private System.Windows.Forms.Button searchCardButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShelving;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShelf;
        private System.Windows.Forms.DataGridView freeCouponsGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboDoctor;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboTreatmentType;
        private System.Windows.Forms.Label labelTreatmentType;
        private System.Windows.Forms.Label labelReceptionCategory;
        private System.Windows.Forms.ComboBox comboReceptionCategory;
        private System.Windows.Forms.Label labelPolicy;
        private System.Windows.Forms.TextBox textPolicy;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnGetCoupon;
        private System.Windows.Forms.ErrorProvider errorShowCoupon;
        private System.Windows.Forms.ErrorProvider errorGetCoupon;
        private System.Windows.Forms.ListBox listGetCouponMessage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridCouponDate;
        private System.Windows.Forms.Button buttonPrintDate;
        private System.Windows.Forms.Button buttonCouponDate;
        private System.Windows.Forms.ErrorProvider errorProviderCouponDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDoctor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
        private System.Windows.Forms.DataGridView gridCouponDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatient1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDoctor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpecialty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect1;
        private System.Windows.Forms.Label labelDoctor2;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.ErrorProvider errorProviderCouponDoctor;
        private System.Windows.Forms.DataGridView gridCouponSpecialty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private System.Windows.Forms.Button buttonPrintCouponDoctor;
        private System.Windows.Forms.Button buttonSeleceCoupon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.ErrorProvider errorProviderCouponSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelectCoupon;
        private System.Windows.Forms.Button buttonPrintCoupon;
    }
}

