using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CouponSelect
    {
        private string treatment;
        public string TreatmentType
        {
            get { return treatment; }
            set
            {
                treatment = value;
            }
        }
        private string patient;
        public string Patient
        {
            get { return patient; }
            set
            {
                patient = value;
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
        private string specialty;
        public string Specialty
        {
            get { return specialty; }
            set
            {
                specialty = value;
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
