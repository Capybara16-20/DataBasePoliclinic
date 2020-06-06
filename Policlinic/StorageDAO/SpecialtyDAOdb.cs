using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace StorageDAO
{
    public class SpecialtyDAOdb
    {
        List<Specialty> specialties = new List<Specialty>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        readonly string outputQuerrySpecialties = @"SELECT Название FROM Специализация";

        string querry;

        public List<Specialty> GetSpecialtiesList()
        {
            specialties.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerrySpecialties, sqlConnection);
                var readerType = sqlCommand.ExecuteReader();
                while (readerType.Read())
                {
                    Specialty specialty = new Specialty()
                    {
                        Name = readerType["Название"].ToString(),
                    };
                    specialties.Add(specialty);
                }
                sqlConnection.Close();
            }
            return specialties;
        }
    }
}
