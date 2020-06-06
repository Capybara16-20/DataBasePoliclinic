using System;
using Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace StorageDAO
{
    public class CouponsDAOdb
    {
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        string querry;

        public int Add(int policy, string category, string appealName, string doctor, DateTime date, DateTime time)
        {
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("AddCoupon", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter policyParam = new SqlParameter
                {
                    ParameterName = "@ПолисОМС",
                    Value = policy
                };
                sqlCommand.Parameters.Add(policyParam);
                SqlParameter categoryParam = new SqlParameter
                {
                    ParameterName = "@Категория",
                    Value = category
                };
                sqlCommand.Parameters.Add(categoryParam);
                SqlParameter appealNameParam = new SqlParameter
                {
                    ParameterName = "@НазваниеОбращения",
                    Value = appealName
                };
                sqlCommand.Parameters.Add(appealNameParam);
                SqlParameter doctorParam = new SqlParameter
                {
                    ParameterName = "@ФИОВрача",
                    Value = doctor
                };
                sqlCommand.Parameters.Add(doctorParam);
                SqlParameter dateParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриема",
                    Value = date
                };
                sqlCommand.Parameters.Add(dateParam);
                SqlParameter timeParam = new SqlParameter
                {
                    ParameterName = "@ВремяТалона",
                    Value = time
                };
                sqlCommand.Parameters.Add(timeParam);
                SqlParameter idParam = sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                idParam.Direction = ParameterDirection.Output;
                sqlCommand.ExecuteNonQuery();
                int.TryParse(idParam.Value.ToString(), out id);
                sqlConnection.Close();
            }
            return id;
        }

        public string PrintCoupon(int id)
        {
            string message = "";
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("printTalon", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@Idталона",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter messageParam = sqlCommand.Parameters.Add("@message", SqlDbType.VarChar, 500);
                messageParam.Direction = ParameterDirection.Output;
                sqlCommand.ExecuteNonQuery();
                message = messageParam.Value.ToString();
                sqlConnection.Close();
            }

            return message;
        }
    }
}
