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
        List<CouponSelect> couponsSelect = new List<CouponSelect>();
        List<Coupon> coupons = new List<Coupon>();

        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Поликлиника;Integrated Security=True";
        readonly string outputQuerryCoupons = @"SELECT IDталона, IDПациента, IDВрача, IDтипаОбращения, ДатаПриема, ВремяТалона FROM Талон";

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

        public string PrintCouponSelect(int id)
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

        public string PrintCoupon(string patient, string treatment, string doctor, DateTime date, DateTime time)
        {
            string message = "";
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("printTalon1", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter patientParam = new SqlParameter
                {
                    ParameterName = "@ФИОПациента",
                    Value = patient
                };
                sqlCommand.Parameters.Add(patientParam);
                SqlParameter treatmentParam = new SqlParameter
                {
                    ParameterName = "@НазваниеОбращения",
                    Value = treatment
                };
                sqlCommand.Parameters.Add(treatmentParam);
                SqlParameter doctorParam = new SqlParameter
                {
                    ParameterName = "@ФИОврача",
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
                SqlParameter messageParam = sqlCommand.Parameters.Add("@message", SqlDbType.VarChar, 500);
                messageParam.Direction = ParameterDirection.Output;
                sqlCommand.ExecuteNonQuery();
                message = messageParam.Value.ToString();
                sqlConnection.Close();
            }
            return message;
        }

        public List<CouponSelect> GetCouponsDateList(DateTime dateAfter, DateTime dateBefore)
        {
            couponsSelect.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("RegPOISK1", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter dateAfterParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриемаНачало",
                    Value = dateAfter
                };
                sqlCommand.Parameters.Add(dateAfterParam);
                SqlParameter dateBeforeParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриемаКонец",
                    Value = dateBefore
                };
                sqlCommand.Parameters.Add(dateBeforeParam);
                using (SqlDataReader couponReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (couponReader.Read())
                    {
                        CouponSelect coupon = new CouponSelect()
                        {
                            TreatmentType = couponReader.GetValue(0).ToString(),
                            Patient = couponReader.GetValue(1).ToString(),
                            Doctor = couponReader.GetValue(2).ToString(),
                            Specialty = couponReader.GetValue(3).ToString(),
                            Date = DateTime.Parse(couponReader.GetValue(4).ToString()),
                            Time = DateTime.Parse(couponReader.GetValue(5).ToString())
                        };
                        couponsSelect.Add(coupon);
                    }
                }
                sqlConnection.Close();
            }
            return couponsSelect;
        }

        public List<CouponSelect> GetCouponsDoctorList(DateTime dateAfter, DateTime dateBefore, string doctor)
        {
            couponsSelect.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("RegPOISK2", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter dateAfterParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриемаНачало",
                    Value = dateAfter
                };
                sqlCommand.Parameters.Add(dateAfterParam);
                SqlParameter dateBeforeParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриемаКонец",
                    Value = dateBefore
                };
                sqlCommand.Parameters.Add(dateBeforeParam);
                SqlParameter doctorParam = new SqlParameter
                {
                    ParameterName = "@ФИОВрача",
                    Value = doctor
                };
                sqlCommand.Parameters.Add(doctorParam);
                using (SqlDataReader couponReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (couponReader.Read())
                    {
                        CouponSelect coupon = new CouponSelect()
                        {
                            TreatmentType = couponReader.GetValue(0).ToString(),
                            Patient = couponReader.GetValue(1).ToString(),
                            Doctor = couponReader.GetValue(2).ToString(),
                            Specialty = couponReader.GetValue(3).ToString(),
                            Date = DateTime.Parse(couponReader.GetValue(4).ToString()),
                            Time = DateTime.Parse(couponReader.GetValue(5).ToString())
                        };
                        couponsSelect.Add(coupon);
                    }
                }
                sqlConnection.Close();
            }
            return couponsSelect;
        }

        public List<CouponSelect> GetCouponsSpecialtyList(DateTime dateAfter, DateTime dateBefore, string specialty)
        {
            couponsSelect.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("RegPOISK3", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter dateAfterParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриемаНачало",
                    Value = dateAfter
                };
                sqlCommand.Parameters.Add(dateAfterParam);
                SqlParameter dateBeforeParam = new SqlParameter
                {
                    ParameterName = "@ДатаПриемаКонец",
                    Value = dateBefore
                };
                sqlCommand.Parameters.Add(dateBeforeParam);
                SqlParameter specialtyParam = new SqlParameter
                {
                    ParameterName = "@Названиеспециализации",
                    Value = specialty
                };
                sqlCommand.Parameters.Add(specialtyParam);
                using (SqlDataReader couponReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (couponReader.Read())
                    {
                        CouponSelect coupon = new CouponSelect()
                        {
                            TreatmentType = couponReader.GetValue(0).ToString(),
                            Patient = couponReader.GetValue(1).ToString(),
                            Doctor = couponReader.GetValue(2).ToString(),
                            Specialty = couponReader.GetValue(3).ToString(),
                            Date = DateTime.Parse(couponReader.GetValue(4).ToString()),
                            Time = DateTime.Parse(couponReader.GetValue(5).ToString())

                        };
                        couponsSelect.Add(coupon);
                    }
                }
                sqlConnection.Close();
            }
            return couponsSelect;
        }

        public List<Coupon> GetCouponsList()
        {
            coupons.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryCoupons, sqlConnection);
                var readerPatient = sqlCommand.ExecuteReader();
                while (readerPatient.Read())
                {
                    Coupon coupon = new Coupon()
                    {
                        ID = Int32.Parse(readerPatient["IDталона"].ToString().Trim()),
                        Patient = Int32.Parse(readerPatient["IDПациента"].ToString().Trim()),
                        Doctor = Int32.Parse(readerPatient["IDВрача"].ToString().Trim()),
                        TreatmentType = Int32.Parse(readerPatient["IDтипаОбращения"].ToString().Trim()),
                        Date = DateTime.Parse(readerPatient["ДатаПриема"].ToString()),
                        Time = DateTime.Parse(readerPatient["ВремяТалона"].ToString())
                    };
                    coupons.Add(coupon);
                }
                sqlConnection.Close();
            }
            return coupons;
        }
    }
}
