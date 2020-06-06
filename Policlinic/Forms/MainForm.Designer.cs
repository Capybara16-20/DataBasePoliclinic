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
            this.поликлиникаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поликлиникаDataSet = new Forms.ПоликлиникаDataSet();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorShowCoupon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGetCoupon = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPolicy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShelving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCardGridView)).BeginInit();
            this.tabCoupons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeCouponsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShowCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGetCoupon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRegistration);
            this.tabControl.Controls.Add(this.tabCards);
            this.tabControl.Controls.Add(this.tabCoupons);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 450);
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
            this.tabRegistration.Size = new System.Drawing.Size(852, 424);
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
            this.patientsGrid.Size = new System.Drawing.Size(846, 394);
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
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
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
            this.tabCards.Size = new System.Drawing.Size(852, 424);
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
            this.txtPolicy,
            this.columnBirthdate,
            this.columnAddress,
            this.columnShelving,
            this.columnShelf});
            this.searchCardGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchCardGridView.Location = new System.Drawing.Point(3, 113);
            this.searchCardGridView.Name = "searchCardGridView";
            this.searchCardGridView.Size = new System.Drawing.Size(846, 308);
            this.searchCardGridView.TabIndex = 7;
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
            this.tabCoupons.Size = new System.Drawing.Size(852, 424);
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
            this.button2.Size = new System.Drawing.Size(110, 76);
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
            this.freeCouponsGridView.Size = new System.Drawing.Size(846, 279);
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
            // columnName
            // 
            this.columnName.HeaderText = "Фамилия";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnPatronymic
            // 
            this.columnPatronymic.HeaderText = "Имя";
            this.columnPatronymic.Name = "columnPatronymic";
            this.columnPatronymic.ReadOnly = true;
            // 
            // txtSurname
            // 
            this.txtSurname.HeaderText = "Отчество";
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            // 
            // txtPolicy
            // 
            this.txtPolicy.HeaderText = "Полис ОМС";
            this.txtPolicy.Name = "txtPolicy";
            this.txtPolicy.ReadOnly = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorShowCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGetCoupon)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPolicy;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShelving;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShelf;
    }
}

