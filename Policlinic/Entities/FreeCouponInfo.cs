using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class FreeCouponInfo
    {
        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
            }
        }
        private string appealName;
        public string AppealName
        {
            get { return appealName; }
            set
            {
                appealName = value;
            }
        }
        private string doctor;
        public string Doctor
        {
            get { return doctor; }
            set
            {
                doctor = value;
            }
        }
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }
    }
}
