using System;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;
using System.Text;

namespace StorageDAO
{
    public class FreeCouponsInfoDAOdb
    {
        List<FreeCouponInfo> freeCoupons = new List<FreeCouponInfo>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        string querry;

        public List<FreeCouponInfo> GetFreeCouponsList(string receptionCategory, string appealName, string doctorName, DateTime date)
        {
            freeCoupons.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Reg1", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter receptionCategoryParam = new SqlParameter
                {
                    ParameterName = "@КатегорияПриема",
                    Value = receptionCategory
                };
                sqlCommand.Parameters.Add(receptionCategoryParam);
                SqlParameter appealNameParam = new SqlParameter
                {
                    ParameterName = "@НазваниеОбращения",
                    Value = appealName
                };
                sqlCommand.Parameters.Add(appealNameParam);
                SqlParameter doctorParam = new SqlParameter
                {
                    ParameterName = "@ФИОВрача",
                    Value = doctorName
                };
                sqlCommand.Parameters.Add(doctorParam);
                SqlParameter dateParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриема",
                    Value = date
                };
                sqlCommand.Parameters.Add(dateParam);
                var readerFreeCouponInfo = sqlCommand.ExecuteReader();
                while (readerFreeCouponInfo.Read())
                {
                    FreeCouponInfo freeCouponInfo = new FreeCouponInfo()
                    {
                        Category = readerFreeCouponInfo[0].ToString().Trim(),
                        AppealName = readerFreeCouponInfo[1].ToString().Trim(),
                        Doctor = readerFreeCouponInfo[2].ToString().Trim(),
                        Date = DateTime.Parse(readerFreeCouponInfo[3].ToString()),
                        Time = DateTime.Parse(readerFreeCouponInfo[4].ToString()),
                    };
                    freeCoupons.Add(freeCouponInfo);
                }
                sqlConnection.Close();
            }
            return freeCoupons;
        }
    }
}
