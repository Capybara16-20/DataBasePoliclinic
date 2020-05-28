using Actions;
using System;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class PatientRegistrarionForm : Form
    {
        BusinessLogic bl = new BusinessLogic();

        public PatientRegistrarionForm(BusinessLogic bl)
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            bool isExists = false;
            string surname = txtSurname.Text;
            string name = txtName.Text;
            string patronomyc = txtPatronymic.Text;
            Int32.TryParse(txtPolicy.Text, out int policy);
            DateTime.TryParse(dateTimePicker1.Value.ToString(), out DateTime birthdate);
            string gender = string.Empty;
            if (comboBoxGender.SelectedIndex > -1)
            {
                gender = comboBoxGender.SelectedItem.ToString();
            }
            string address = txtAddress.Text;
            Int32.TryParse(txtShelving.Text, out int shelving);
            Int32.TryParse(txtShelf.Text, out int shelf);

            if ((surname != string.Empty) && (name != string.Empty) && (patronomyc != string.Empty) && (policy != 0) && (birthdate != new DateTime()) 
                && (gender != string.Empty) && (address != string.Empty) && (shelving != 0) && (shelf != 0))
            {
                foreach (var patient in bl.GetPatientsList())
                {
                    if (patient.Policy == policy)
                    {
                        MessageBox.Show("Пациент с таким полисом уже существует!");
                        isExists = true;
                        txtPolicy.Text = string.Empty;
                        break;
                    }
                }
                if (!isExists)
                {
                    bl.AddPatient(surname, name, patronomyc, policy, birthdate, gender, address, shelving, shelf);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Данные не введены!");
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(txtSurname.Text)) && (Regex.IsMatch(txtSurname.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                txtSurname.Focus();
                errorProvider.SetError(txtSurname, "Некорректный формат фамилии!");
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(txtName.Text)) && (Regex.IsMatch(txtName.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                txtName.Focus();
                errorProvider.SetError(txtName, "Некорректный формат имени!");
            }
        }

        private void txtPatronymic_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(txtPatronymic.Text)) && (Regex.IsMatch(txtPatronymic.Text, @"[а-я]")))
            {
                errorProvider.Clear();
            }
            else
            {
                txtPatronymic.Focus();
                errorProvider.SetError(txtPatronymic, "Некорректный формат отчества!");
            }
        }

        private void txtPolicy_Validating(object sender, CancelEventArgs e)
        {
            if ((!String.IsNullOrEmpty(txtPolicy.Text)) && (Regex.IsMatch(txtPolicy.Text, @"[0-9]")) && (txtPolicy.Text.Length == 6))
            {
                errorProvider.Clear();
            }
            else
            {
                txtPolicy.Focus();
                errorProvider.SetError(txtPolicy, "Некорректный формат полиса!");
            }
        }

        private void comboBoxGender_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxGender.SelectedIndex > -1)
            {
                errorProvider.Clear();
            }
            else
            {
                comboBoxGender.Focus();
                errorProvider.SetError(comboBoxGender, "Пол не выбран!");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider.Clear();
            }
            else
            {
                txtAddress.Focus();
                errorProvider.SetError(txtAddress, "Адрес не введён!");
            }
        }

        private void txtShelving_Validating(object sender, CancelEventArgs e)
        {
            Int32.TryParse(txtShelving.Text, out int shelving);
            if ((!String.IsNullOrEmpty(txtShelving.Text)) && (Regex.IsMatch(txtShelving.Text, @"[0-9]")) && (shelving > 0))
            {
                errorProvider.Clear();
            }
            else
            {
                txtShelving.Focus();
                errorProvider.SetError(txtShelving, "Некорректный формат номера стеллажа!");
            }
        }

        private void txtShelf_Validating(object sender, CancelEventArgs e)
        {
            Int32.TryParse(txtShelf.Text, out int shef);
            if ((!String.IsNullOrEmpty(txtShelf.Text)) && (Regex.IsMatch(txtShelf.Text, @"[0-9]")) && (shef > 0))
            {
                errorProvider.Clear();
            }
            else
            {
                txtShelf.Focus();
                errorProvider.SetError(txtShelf, "Некорректный формат номера стеллажа!");
            }
        }
    }
}
