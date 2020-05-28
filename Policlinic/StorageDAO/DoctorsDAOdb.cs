using System;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;
using System.Text;

namespace StorageDAO
{
    public class DoctorsDAOdb
    {
        List<Doctor> doctors = new List<Doctor>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        string querry;

        public List<Doctor> GetDoctorsList(string treatmentType)
        {
            string outputQuerryDoctors = @"SELECT ФИОВрача FROM Врач WHERE IDспециализацииВрача = "
                                                + "(SELECT IDспециализацииВрача FROM ТипОбращения WHERE НазваниеОбращения = '" + treatmentType + "')";
            doctors.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryDoctors, sqlConnection);
                var readerDoctor = sqlCommand.ExecuteReader();
                while (readerDoctor.Read())
                {
                    Doctor doctor = new Doctor()
                    {
                        Name = readerDoctor["ФИОВрача"].ToString(),
                    };
                    doctors.Add(doctor);
                }
                sqlConnection.Close();
            }
            return doctors;
        }
    }
}
