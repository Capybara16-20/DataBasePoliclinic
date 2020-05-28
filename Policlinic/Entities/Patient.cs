using System;
using System.Text;

namespace Entities
{
    public class Patient
    {
        private int id;
        public int ID
        {
            get
            {
                if (id == 0)
                {
                    id = GetID();
                }
                return id;
            }
            set { }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        private string patronymic;
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
            }
        }
        private int policy;
        public int Policy
        {
            get { return policy; }
            set
            {
                policy = value;
            }
        }
        private DateTime birthdate;
        public DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                if ((value < DateTime.Now) && ((DateTime.Now - value) < (DateTime.Now - new DateTime(DateTime.Now.Year - 150, DateTime.Now.Month, DateTime.Now.Day))))
                {
                    birthdate = value;
                }
            }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if ((value.ToLower() == "мужской") || (value.ToLower() == "женский"))
                {
                    gender = value;
                }
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
        private int shelving;
        public int Shelving
        {
            get { return shelving; }
            set
            {
                shelving = value;
            }
        }
        private int shelf;
        public int Shelf
        {
            get { return shelf; }
            set
            {
                shelf = value;
            }
        }
        public Patient(string surname, string name, string patronymic, int policy, DateTime birthdate,
            string gender, string address, int shelving, int shelf)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Policy = policy;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.Address = address;
            this.Shelving = shelving;
            this.Shelf = shelf;
        }
        public Patient() { }
        private int GetID()
        {
            Guid guid = Guid.NewGuid();
            string strGuid = guid.ToString().Replace("-", "");
            StringBuilder sb = new StringBuilder();
            int count = 0;
            while (sb.Length < 9)
            {
                if (char.IsDigit(strGuid[count]))
                {
                    sb.Append(strGuid[count]);
                }
                count++;
            }
            return Int32.Parse(sb.ToString());
        }
    }
}
