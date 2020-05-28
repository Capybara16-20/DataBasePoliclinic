using System;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;
using System.Text;

namespace StorageDAO
{
    public class TreatmentTypesDAOdb
    {
        List<TreatmentType> treatmentTypes = new List<TreatmentType>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        string querry;

        public List<TreatmentType> GetTreatmentTypesList(string category)
        {
            string outputQuerryTreatmentTypes = @"SELECT НазваниеОбращения FROM ТипОбращения WHERE IDкатегорииПриема = " 
                                                + "(SELECT IDкатегорииПриема FROM КатегорияПриема WHERE Категория = '" + category + "')";
            treatmentTypes.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryTreatmentTypes, sqlConnection);
                var readerType = sqlCommand.ExecuteReader();
                while (readerType.Read())
                {
                    TreatmentType treatmentType = new TreatmentType()
                    {
                        Name = readerType["НазваниеОбращения"].ToString(),
                    };
                    treatmentTypes.Add(treatmentType);
                }
                sqlConnection.Close();
            }
            return treatmentTypes;
        }
    }
}
