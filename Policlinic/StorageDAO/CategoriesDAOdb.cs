using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.Data.SqlClient;

namespace StorageDAO
{
    public class CategoriesDAOdb
    {
        List<Category> categories = new List<Category>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        readonly string outputQuerryCategories = @"SELECT Категория FROM КатегорияПриема";
        string querry;

        public List<Category> GetCategoriesList()
        {
            categories.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryCategories, sqlConnection);
                var readerPatient = sqlCommand.ExecuteReader();
                while (readerPatient.Read())
                {
                    Category category = new Category()
                    {
                        Name = readerPatient["Категория"].ToString().Trim(),
                    };
                    categories.Add(category);
                }
                sqlConnection.Close();
            }
            return categories;
        }
    }
}
