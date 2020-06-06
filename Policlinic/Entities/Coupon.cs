using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Coupon
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set { }
        }
        private int patient;
        public int Patient
        {
            get { return patient; }
            set
            {
                patient = value;
            }
        }
        private int doctor;
        public int Doctor
        {
            get { return doctor; }
            set
            {
                doctor = value;
            }
        }
        private int treatmentType;
        public int TreatmentType
        {
            get { return treatmentType; }
            set
            {
                treatmentType = value;
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
