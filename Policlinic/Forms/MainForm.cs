using Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Forms
{
    public partial class MainForm : Form
    {
        BusinessLogic bl = new BusinessLogic();
        private string print;
        private string[] textPrint;

        public MainForm()
        {
            InitializeComponent();
        }

        public void PatientsGridRenew()
        {

            if (patientsGrid.Rows.Count > 1)
            {
                patientsGrid.Rows.Clear();
            }

            for (int i = 0; i < bl.GetPatientsList().Count; i++)
            {
                patientsGrid.Rows.Add();
                patientsGrid[0, i].Value = bl.GetPatientsList()[i].Surname;
                patientsGrid[1, i].Value = bl.GetPatientsList()[i].Name;
                patientsGrid[2, i].Value = bl.GetPatientsList()[i].Patronymic;
                patientsGrid[3, i].Value = bl.GetPatientsList()[i].Policy;
                patientsGrid[4, i].Value = string.Format("{0:d}", bl.GetPatientsList()[i].Birthdate);
                    
                patientsGrid[5, i].Value = bl.GetPatientsList()[i].Gender;
                patientsGrid[6, i].Value = bl.GetPatientsList()[i].Address;
            }
        }

        public void SearchCardGridRenew(string surname, int year, string address)
        {
            
            if (searchCardGridView.Rows.Count > 1)
            {
                searchCardGridView.Rows.Clear();
            }
            int rowIndex = 0;
            if ((!String.IsNullOrEmpty(surname)) || (year != 0) || (!String.IsNullOrEmpty(address)))
            {
                foreach (var patient in bl.GetPatientsList())
                {
                    if ((String.IsNullOrEmpty(surname)) || (patient.Surname == surname))
                    {
                        if ((year == 0) || (patient.Birthdate.Year == year))
                        {
                            if ((String.IsNullOrEmpty(address)) || patient.Address.Contains(address))
                            {
                                searchCardGridView.Rows.Add();
                                searchCardGridView[0, rowIndex].Value = patient.Surname;
                                searchCardGridView[1, rowIndex].Value = patient.Name;
                                searchCardGridView[2, rowIndex].Value = patient.Patronymic;
                                searchCardGridView[3, rowIndex].Value = string.Format("{0:d}", patient.Birthdate);
                                searchCardGridView[4, rowIndex].Value = patient.Address;
                                searchCardGridView[5, rowIndex].Value = patient.Shelving;
                                searchCardGridView[6, rowIndex].Value = patient.Shelf;
                                rowIndex++;
                            }
                        }
                    }
                }
            }
        }

        public void FreeCouponsGridRenew(string category, string treatmentType, string doctor, DateTime date)
        {
            if (freeCouponsGridView.Rows.Count > 1)
            {
                freeCouponsGridView.Rows.Clear();
            }
            int rowIndex = 0;
            foreach (var freeCoupon in bl.GetFreeCouponsInfo(category, treatmentType, doctor, date))
            {
                freeCouponsGridView.Rows.Add();
                freeCouponsGridView[0, rowIndex].Value = freeCoupon.Category;
                freeCouponsGridView[1, rowIndex].Value = freeCoupon.AppealName;
                freeCouponsGridView[2, rowIndex].Value = freeCoupon.Doctor;
                freeCouponsGridView[3, rowIndex].Value = string.Format("{0:d}", freeCoupon.Date);
                freeCouponsGridView[4, rowIndex].Value = string.Format("{0:t}", freeCoupon.Time);
                rowIndex++;
            }
            freeCouponsGridView.Rows[rowIndex].ReadOnly = true;
        }

        public void GridCouponDateRenew(DateTime dateAfter, DateTime dateBefore)
        {
            if (gridCouponDate.Rows.Count > 1)
            {
                gridCouponDate.Rows.Clear();
            }
            int rowIndex = 0;
            foreach (var couponDate in bl.GetCouponsDateList(dateAfter, dateBefore))
            {
                gridCouponDate.Rows.Add();
                gridCouponDate[0, rowIndex].Value = couponDate.TreatmentType;
                gridCouponDate[1, rowIndex].Value = couponDate.Patient;
                gridCouponDate[2, rowIndex].Value = couponDate.Doctor;
                gridCouponDate[3, rowIndex].Value = couponDate.Specialty;
                gridCouponDate[4, rowIndex].Value = string.Format("{0:d}", couponDate.Date);
                gridCouponDate[5, rowIndex].Value = string.Format("{0:t}", couponDate.Time);
                gridCouponDate[6, rowIndex].ReadOnly = false;
                rowIndex++;
            }
        }

        public void GridCouponDoctorRenew(DateTime dateAfter, DateTime dateBefore, string doctor)
        {
            if (gridCouponDoctor.Rows.Count > 1)
            {
                gridCouponDoctor.Rows.Clear();
            }
            int rowIndex = 0;
            foreach (var couponDate in bl.GetCouponsDoctorList(dateAfter, dateBefore, doctor))
            {
                gridCouponDoctor.Rows.Add();
                gridCouponDoctor[0, rowIndex].Value = couponDate.TreatmentType;
                gridCouponDoctor[1, rowIndex].Value = couponDate.Patient;
                gridCouponDoctor[2, rowIndex].Value = couponDate.Doctor;
                gridCouponDoctor[3, rowIndex].Value = couponDate.Specialty;
                gridCouponDoctor[4, rowIndex].Value = string.Format("{0:d}", couponDate.Date);
                gridCouponDoctor[5, rowIndex].Value = string.Format("{0:t}", couponDate.Time);
                gridCouponDoctor[6, rowIndex].ReadOnly = false;
                rowIndex++;
            }
        }

        public void GridCouponSpecialtyRenew(DateTime dateAfter, DateTime dateBefore, string specialty)
        {
            if (gridCouponSpecialty.Rows.Count > 1)
            {
                gridCouponSpecialty.Rows.Clear();
            }
            int rowIndex = 0;
            foreach (var couponSpecialty in bl.GetCouponsSpecialtyList(dateAfter, dateBefore, specialty))
            {
                gridCouponSpecialty.Rows.Add();
                gridCouponSpecialty[0, rowIndex].Value = couponSpecialty.TreatmentType;
                gridCouponSpecialty[1, rowIndex].Value = couponSpecialty.Patient;
                gridCouponSpecialty[2, rowIndex].Value = couponSpecialty.Doctor;
                gridCouponSpecialty[3, rowIndex].Value = couponSpecialty.Specialty;
                gridCouponSpecialty[4, rowIndex].Value = string.Format("{0:d}", couponSpecialty.Date);
                gridCouponSpecialty[5, rowIndex].Value = string.Format("{0:t}", couponSpecialty.Time);
                gridCouponSpecialty[6, rowIndex].ReadOnly = false;
                rowIndex++;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PatientsGridRenew();

            foreach (var category in bl.GetCategoriesList())
            {
                comboReceptionCategory.Items.Add(category.Name.ToString());
            }

            foreach (var doctor in bl.GetDoctorsList())
            {
                comboBoxDoctor.Items.Add(doctor.Name.ToString());
            }

            foreach (var specialty in bl.GetSpecialtiesList())
            {
                comboBoxSpecialty.Items.Add(specialty.Name.ToString());
            }

            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.MaxDate = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker4.MaxDate = DateTime.Today;
            dateTimePicker4.Value = DateTime.Today;
            dateTimePicker5.MaxDate = DateTime.Today;
            dateTimePicker5.Value = DateTime.Today;
            dateTimePicker6.MaxDate = DateTime.Today;
            dateTimePicker6.Value = DateTime.Today;
            dateTimePicker7.MaxDate = DateTime.Today;
            dateTimePicker7.Value = DateTime.Today;
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientRegistrarionForm patientRegistrarionForm = new PatientRegistrarionForm(bl);
            patientRegistrarionForm.ShowDialog();
            PatientsGridRenew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textSurname.Text;
            Int32.TryParse(textYear.Text, out int year);
            string address = textAddress.Text;
            if ((String.IsNullOrEmpty(surname)) && (year == 0) && (String.IsNullOrEmpty(address)))
            {
                MessageBox.Show("Данные для поиска не введены!");
            }
            else
            {
                SearchCardGridRenew(surname, year, address);
                if (searchCardGridView.Rows.Count == 1)
                {
                    MessageBox.Show("По введённым данным ничего не найдено!");
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if ((String.IsNullOrEmpty(textSurname.Text)) || (Regex.IsMatch(textSurname.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(textSurname, "Некорректный формат фамилии!");
            }
        }

        private void textYear_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(textYear.Text)) || ((Regex.IsMatch(textYear.Text, @"[0-9]")) && (textYear.Text.Length == 4)))
            {
                if ((Int32.Parse(textYear.Text) > 1900) && (Int32.Parse(textYear.Text) < 2020))
                {
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(textYear, "Некорректный год!");
                }
            }
            else if (String.IsNullOrEmpty(textYear.Text))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(textYear, "Некорректный формат года рождения!");
            }
        }

        private void comboReceptionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTreatmentType.Items.Clear();
            comboDoctor.Items.Clear();
            string category = comboReceptionCategory.SelectedItem.ToString();
            foreach (var treatmentType in bl.GetTreatmentTypesList(category))
            {
                comboTreatmentType.Items.Add(treatmentType.Name.ToString());
            }
        }

        private void comboTreatmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoctor.Items.Clear();
            string treatmentType = comboTreatmentType.SelectedItem.ToString();
            foreach (var doctor in bl.GetDoctorsList(treatmentType))
            {
                comboDoctor.Items.Add(doctor.Name.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboReceptionCategory.SelectedIndex > -1)
            {
                errorShowCoupon.Clear();
                if (comboTreatmentType.SelectedIndex > -1)
                {
                    errorShowCoupon.Clear();
                    if (comboDoctor.SelectedIndex > -1)
                    {
                        errorShowCoupon.Clear();
                    }
                    else
                    {
                        errorShowCoupon.SetError(comboDoctor, "Не выбран врач!");
                    }
                }
                else
                {
                    errorShowCoupon.SetError(comboTreatmentType, "Не выбран тип обращения!");
                }
            }
            else
            {
                errorShowCoupon.SetError(comboReceptionCategory, "Не выбрана категория приёма!");
            }

            if ((comboReceptionCategory.SelectedIndex > -1) && (comboTreatmentType.SelectedIndex > -1)
                && (comboDoctor.SelectedIndex > -1))
            {
                string category = comboReceptionCategory.SelectedItem.ToString();
                string treatmentType = comboTreatmentType.SelectedItem.ToString();
                string doctor = comboDoctor.SelectedItem.ToString();
                DateTime date = dateTimePicker1.Value;
                FreeCouponsGridRenew(category, treatmentType, doctor, date);
                freeCouponsGridView.Enabled = true;
            }
            else
            {
                MessageBox.Show("Данные для поиска не введены!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isExists = false;
            int index = 0;
            if (String.IsNullOrEmpty(textPolicy.Text))
            {
                errorProvider.SetError(textPolicy, "Полис не введён!");
            }
            else if ((Regex.IsMatch(textPolicy.Text, @"[0-9]")) && (textPolicy.Text.Length == 6))
            {
                errorProvider.Clear();

                int count = 0;
                foreach (DataGridViewRow row in freeCouponsGridView.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["columnGetCoupon"].Value))
                    {
                        index = row.Index;
                        count++;
                    }
                }
                if (count < 1)
                {
                    MessageBox.Show("Не выбран талон!");
                }
                else if (count > 1)
                {
                    MessageBox.Show("Выберите один талон!");
                }
                else
                {
                    foreach (var patient in bl.GetPatientsList())
                    {
                        if (patient.Policy == Int32.Parse(textPolicy.Text))
                        {
                            isExists = true;
                            break;
                        }
                    }
                    if (!isExists)
                    {
                        MessageBox.Show("Пациента с таким полисом не существует!");
                    }
                    else
                    {
                        int.TryParse(textPolicy.Text, out int policy);
                        string category = freeCouponsGridView[0, index].Value.ToString();
                        string treatmentType = freeCouponsGridView[1, index].Value.ToString();
                        string doctor = freeCouponsGridView[2, index].Value.ToString();
                        DateTime date = DateTime.Parse(freeCouponsGridView[3, index].Value.ToString());
                        DateTime time = DateTime.Parse(freeCouponsGridView[4, index].Value.ToString());
                        int id = bl.AddCoupon(policy, category, treatmentType, doctor, date, time);
                        textPolicy.Text = string.Empty;
                        freeCouponsGridView.Rows.Clear();
                        comboDoctor.Items.Clear();
                        comboTreatmentType.Items.Clear();
                        string[] text = bl.PrintCouponSelect(id).Split(',');
                        listGetCouponMessage.Items.AddRange(text);
                        textPrint = text;
                    }
                }
            }
            else
            {
                textPolicy.Focus();
                errorProvider.SetError(textPolicy, "Некорректный формат полиса!");
            }
        }

        private void buttonCouponDate_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker2.Value, dateTimePicker3.Value) > 0)
            {
                errorProviderCouponDate.SetError(dateTimePicker2, "Некорректный период!");
                errorProviderCouponDate.SetError(dateTimePicker3, "Некорректный период!");
            }
            else
            {
                errorProviderCouponDate.Clear();
                GridCouponDateRenew(dateTimePicker2.Value, dateTimePicker3.Value);
            }
        }

        private void buttonPrintDate_Click(object sender, EventArgs e)
        {
            int index = 0;
            int count = 0;
            foreach (DataGridViewRow row in gridCouponDate.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumnSelect"].Value))
                {
                    index = row.Index;
                    count++;
                }
            }
            if (count < 1)
            {
                MessageBox.Show("Не выбран талон!");
            }
            else if (count > 1)
            {
                MessageBox.Show("Выберите один талон!");
            }
            else
            {
                string treatment = gridCouponDate[0, index].Value.ToString();
                string patient = gridCouponDate[1, index].Value.ToString();
                string doctor = gridCouponDate[2, index].Value.ToString();
                DateTime date = DateTime.Parse(gridCouponDate[4, index].Value.ToString());
                DateTime time = DateTime.Parse(gridCouponDate[5, index].Value.ToString());

                string[] text = bl.PrintCoupon(patient, treatment, doctor, date, time).Split(',');
                for (int i = 0; i < text.Length; i++)
                {
                    print = print + text[i] + "\n";
                }

                MessageBox.Show(print);

                gridCouponDate.Rows.Clear();
                dateTimePicker2.Value = DateTime.Today;
                dateTimePicker3.Value = DateTime.Today;
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(print, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            errorProviderCouponDoctor.Clear();
            if (DateTime.Compare(dateTimePicker5.Value, dateTimePicker4.Value) > 0)
            {
                errorProviderCouponDoctor.SetError(dateTimePicker4, "Некорректный период!");
                errorProviderCouponDoctor.SetError(dateTimePicker5, "Некорректный период!");
            }
            else
            {
                if (comboBoxDoctor.SelectedIndex > -1)
                {
                    errorProviderCouponDoctor.Clear();
                    GridCouponDoctorRenew(dateTimePicker5.Value, dateTimePicker4.Value, comboBoxDoctor.SelectedItem.ToString());
                }
                else
                {
                    errorProviderCouponDoctor.SetError(comboBoxDoctor, "Не выбран врач!");
                }
            }
            
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            int index = 0;
            int count = 0;
            foreach (DataGridViewRow row in gridCouponDoctor.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumnSelect1"].Value))
                {
                    index = row.Index;
                    count++;
                }
            }
            if (count < 1)
            {
                MessageBox.Show("Не выбран талон!");
            }
            else if (count > 1)
            {
                MessageBox.Show("Выберите один талон!");
            }
            else
            {
                string treatment = gridCouponDoctor[0, index].Value.ToString();
                string patient = gridCouponDoctor[1, index].Value.ToString();
                string doctor = gridCouponDoctor[2, index].Value.ToString();
                DateTime date = DateTime.Parse(gridCouponDoctor[4, index].Value.ToString());
                DateTime time = DateTime.Parse(gridCouponDoctor[5, index].Value.ToString());

                string[] text = bl.PrintCoupon(patient, treatment, doctor, date, time).Split(',');
                for (int i = 0; i < text.Length; i++)
                {
                    print = print + text[i] + "\n";
                }

                MessageBox.Show(print);

                gridCouponDoctor.Rows.Clear();
                dateTimePicker4.Value = DateTime.Today;
                dateTimePicker5.Value = DateTime.Today;
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
                print = string.Empty;
            }
        }

        private void buttonSeleceCoupon_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker7.Value, dateTimePicker6.Value) > 0)
            {
                errorProviderCouponSpecialty.SetError(dateTimePicker6, "Некорректный период!");
                errorProviderCouponSpecialty.SetError(dateTimePicker7, "Некорректный период!");
            }
            else
            {
                errorProviderCouponSpecialty.Clear();
                if (comboBoxSpecialty.SelectedIndex > -1)
                {
                    errorProviderCouponSpecialty.Clear();
                    GridCouponSpecialtyRenew(dateTimePicker7.Value, dateTimePicker6.Value, comboBoxSpecialty.SelectedItem.ToString());
                }
                else
                {
                    errorProviderCouponSpecialty.SetError(comboBoxSpecialty, "Не выбрана специализация!");
                }
            }
        }

        private void buttonPrintCouponDoctor_Click(object sender, EventArgs e)
        {
            int index = 0;
            int count = 0;
            foreach (DataGridViewRow row in gridCouponSpecialty.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumnSelectCoupon"].Value))
                {
                    index = row.Index;
                    count++;
                }
            }
            if (count < 1)
            {
                MessageBox.Show("Не выбран талон!");
            }
            else if (count > 1)
            {
                MessageBox.Show("Выберите один талон!");
            }
            else
            {
                string treatment = gridCouponSpecialty[0, index].Value.ToString();
                string patient = gridCouponSpecialty[1, index].Value.ToString();
                string doctor = gridCouponSpecialty[2, index].Value.ToString();
                DateTime date = DateTime.Parse(gridCouponSpecialty[4, index].Value.ToString());
                DateTime time = DateTime.Parse(gridCouponSpecialty[5, index].Value.ToString());
                string[] text = bl.PrintCoupon(patient, treatment, doctor, date, time).Split(',');
                for (int i = 0; i < text.Length; i++)
                {
                    print = print + text[i] + "\n";
                }

                MessageBox.Show(print);

                gridCouponDoctor.Rows.Clear();
                dateTimePicker6.Value = DateTime.Today;
                dateTimePicker7.Value = DateTime.Today;
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
                print = string.Empty;
            }
        }

        private void buttonPrintCoupon_Click(object sender, EventArgs e)
        {
            if (listGetCouponMessage.Text != "")
            {
                MessageBox.Show("Талон не выписан!");
            }
            else
            {
                for (int i = 0; i < textPrint.Length; i++)
                {
                    print = print + textPrint[i] + "\n";
                }

                MessageBox.Show(print);

                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
                print = string.Empty;
            }
        }
    }
}
