using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace StorageDAO
{
    public class PatientsDAOdb
    {
        List<Patient> patients = new List<Patient>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        readonly string outputQuerryPatients = @"SELECT IDПациента, ФамилияПациента, ИмяПациента, ОтчествоПациента, ПолисОМС, ДатаРождения, "
                    + "Пол, Адрес, НомерСтеллажа, НомерПолки FROM Пациент";
        string querry;

        public void Add(Patient patient)
        {
            patients.Add(patient);
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("PatientInsert", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter surnameParam = new SqlParameter
                {
                    ParameterName = "@ФамилияПациента",
                    Value = patient.Surname
                };
                sqlCommand.Parameters.Add(surnameParam);
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@ИмяПациента",
                    Value = patient.Name
                };
                sqlCommand.Parameters.Add(nameParam);
                SqlParameter patronymicParam = new SqlParameter
                {
                    ParameterName = "@ОтчествоПациента",
                    Value = patient.Patronymic
                };
                sqlCommand.Parameters.Add(patronymicParam);
                SqlParameter policyParam = new SqlParameter
                {
                    ParameterName = "@ПолисОМС",
                    Value = patient.Policy
                };
                sqlCommand.Parameters.Add(policyParam);
                SqlParameter birthdateParam = new SqlParameter
                {
                    ParameterName = "@ДатаРождения",
                    Value = patient.Birthdate
                };
                sqlCommand.Parameters.Add(birthdateParam);
                SqlParameter genderParam = new SqlParameter
                {
                    ParameterName = "@Пол",
                    Value = patient.Gender
                };
                sqlCommand.Parameters.Add(genderParam);
                SqlParameter addressParam = new SqlParameter
                {
                    ParameterName = "@Адрес",
                    Value = patient.Address
                };
                sqlCommand.Parameters.Add(addressParam);
                SqlParameter shelvingParam = new SqlParameter
                {
                    ParameterName = "@НомерСтеллажа",
                    Value = patient.Shelving
                };
                sqlCommand.Parameters.Add(shelvingParam);
                SqlParameter shelfParam = new SqlParameter
                {
                    ParameterName = "@НомерПолки",
                    Value = patient.Shelf
                };
                sqlCommand.Parameters.Add(shelfParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<Patient> GetPatientsList()
        {
            patients.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryPatients, sqlConnection);
                var readerPatient = sqlCommand.ExecuteReader();
                while (readerPatient.Read())
                {
                    Patient patient = new Patient()
                    {
                        ID = Int32.Parse(readerPatient["IDПациента"].ToString().Trim()),
                        Surname = readerPatient["ФамилияПациента"].ToString().Trim(),
                        Name = readerPatient["ИмяПациента"].ToString().Trim(),
                        Patronymic = readerPatient["ОтчествоПациента"].ToString().Trim(),
                        Policy = Int32.Parse(readerPatient["ПолисОМС"].ToString().Trim()),
                        Birthdate = DateTime.Parse(readerPatient["ДатаРождения"].ToString()),
                        Gender = readerPatient["Пол"].ToString().Trim(),
                        Address = readerPatient["Адрес"].ToString().Trim(),
                        Shelving = Int32.Parse(readerPatient["НомерСтеллажа"].ToString().Trim()),
                        Shelf = Int32.Parse(readerPatient["НомерПолки"].ToString().Trim()),
                    };
                    patients.Add(patient);
                }
                sqlConnection.Close();
            }
            return patients;
        }
    }
}
