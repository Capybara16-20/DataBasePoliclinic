using Entities;
using StorageDAO;
using System;
using System.Collections.Generic;

namespace Actions
{
    public class BusinessLogic
    {
        PatientsDAOdb patients = new PatientsDAOdb();
        CouponsDAOdb coupons = new CouponsDAOdb();
        FreeCouponsInfoDAOdb freeCouponInfo = new FreeCouponsInfoDAOdb();
        CategoriesDAOdb categories = new CategoriesDAOdb();
        TreatmentTypesDAOdb treatmentTypes = new TreatmentTypesDAOdb();
        DoctorsDAOdb doctors = new DoctorsDAOdb();
        CouponsDAOdb coupon = new CouponsDAOdb();

        public List<Patient> GetPatientsList()
        {
            return patients.GetPatientsList();
        }

        public void AddPatient(string surname, string name, string patronymic, int policy, DateTime birthdate, 
            string gender, string address, int shelving, int shelf)
        {
            Patient patient = new Patient(surname, name, patronymic, policy, birthdate, gender, address, shelving, shelf);
            patients.Add(patient);
        }

        public int AddCoupon(int policy, string category, string appealName, string doctor, DateTime date, DateTime time)
        {
            return coupons.Add(policy, category, appealName, doctor, date, time);
        }

        public List<FreeCouponInfo> GetFreeCouponsInfo(string receptionCategory, string appealName, string doctorName, DateTime date)
        {
            return freeCouponInfo.GetFreeCouponsList(receptionCategory, appealName, doctorName, date);
        }

        public List<Category> GetCategoriesList()
        {
            
            return categories.GetCategoriesList();
        }

        public List<TreatmentType> GetTreatmentTypesList(string category)
        {
            return treatmentTypes.GetTreatmentTypesList(category);
        }

        public List<Doctor> GetDoctorsList(string treatmentType)
        {
            return (doctors.GetDoctorsList(treatmentType));
        }

        public string PrintCoupon(int id)
        {
            return coupon.PrintCoupon(id);
        }
    }
}
