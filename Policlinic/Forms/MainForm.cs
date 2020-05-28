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

namespace Forms
{
    public partial class MainForm : Form
    {
        BusinessLogic bl = new BusinessLogic();

        public MainForm()
        {
            InitializeComponent();

            bl.GetPatientsList();

            foreach (var category in bl.GetCategoriesList())
            {
                comboReceptionCategory.Items.Add(category.Name.ToString());
            }
            
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

        private void Main_Load(object sender, EventArgs e)
        {
            PatientsGridRenew();
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
                        comboReceptionCategory.Items.Clear();
                        string[] text = bl.PrintCoupon(id).Split(',');
                        listGetCouponMessage.Items.AddRange(text);
                    }
                }
            }
            else
            {
                textPolicy.Focus();
                errorProvider.SetError(textPolicy, "Некорректный формат полиса!");
            }
        }
    }
}
