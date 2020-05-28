namespace Forms
{
    partial class PatientRegistrarionForm
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.txtPolicy = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtShelving = new System.Windows.Forms.TextBox();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelPolicy = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelShelving = new System.Windows.Forms.Label();
            this.labelShelf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(111, 12);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(231, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(111, 64);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(231, 20);
            this.txtPatronymic.TabIndex = 2;
            this.txtPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatronymic_Validating);
            // 
            // txtPolicy
            // 
            this.txtPolicy.Location = new System.Drawing.Point(111, 90);
            this.txtPolicy.Name = "txtPolicy";
            this.txtPolicy.Size = new System.Drawing.Size(231, 20);
            this.txtPolicy.TabIndex = 3;
            this.txtPolicy.Validating += new System.ComponentModel.CancelEventHandler(this.txtPolicy_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 116);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 5, 26, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(111, 142);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(231, 21);
            this.comboBoxGender.TabIndex = 5;
            this.comboBoxGender.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGender_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 169);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 20);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // txtShelving
            // 
            this.txtShelving.Location = new System.Drawing.Point(111, 195);
            this.txtShelving.Name = "txtShelving";
            this.txtShelving.Size = new System.Drawing.Size(231, 20);
            this.txtShelving.TabIndex = 7;
            this.txtShelving.Validating += new System.ComponentModel.CancelEventHandler(this.txtShelving_Validating);
            // 
            // txtShelf
            // 
            this.txtShelf.Location = new System.Drawing.Point(111, 221);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.Size = new System.Drawing.Size(231, 20);
            this.txtShelf.TabIndex = 8;
            this.txtShelf.Validating += new System.ComponentModel.CancelEventHandler(this.txtShelf_Validating);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.registrationButton.Location = new System.Drawing.Point(12, 247);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(330, 23);
            this.registrationButton.TabIndex = 9;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 9);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 11;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(12, 67);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 13;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelPolicy
            // 
            this.labelPolicy.AutoSize = true;
            this.labelPolicy.Location = new System.Drawing.Point(12, 93);
            this.labelPolicy.Name = "labelPolicy";
            this.labelPolicy.Size = new System.Drawing.Size(66, 13);
            this.labelPolicy.TabIndex = 14;
            this.labelPolicy.Text = "Полис ОМС";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Location = new System.Drawing.Point(12, 116);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(86, 13);
            this.labelBirthdate.TabIndex = 15;
            this.labelBirthdate.Text = "Дата рождения";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(12, 142);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "Пол";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 169);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Адрес";
            // 
            // labelShelving
            // 
            this.labelShelving.AutoSize = true;
            this.labelShelving.Location = new System.Drawing.Point(12, 195);
            this.labelShelving.Name = "labelShelving";
            this.labelShelving.Size = new System.Drawing.Size(93, 13);
            this.labelShelving.TabIndex = 18;
            this.labelShelving.Text = "Номер стеллажа";
            // 
            // labelShelf
            // 
            this.labelShelf.AutoSize = true;
            this.labelShelf.Location = new System.Drawing.Point(12, 221);
            this.labelShelf.Name = "labelShelf";
            this.labelShelf.Size = new System.Drawing.Size(74, 13);
            this.labelShelf.TabIndex = 19;
            this.labelShelf.Text = "Номер полки";
            // 
            // PatientRegistrarionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 279);
            this.Controls.Add(this.labelShelf);
            this.Controls.Add(this.labelShelving);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelPolicy);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.txtShelf);
            this.Controls.Add(this.txtShelving);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPolicy);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "PatientRegistrarionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пациента";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.TextBox txtPolicy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtShelving;
        private System.Windows.Forms.TextBox txtShelf;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelShelving;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelPolicy;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShelf;
    }
}