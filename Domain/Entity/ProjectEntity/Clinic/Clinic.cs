using Domain.Entity.ProjectEntity.Financial;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Clinic
{
    public class Clinic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Spicalist { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string phoneNumber { get; set; }
        public string Mobile { get; set; }
        public string fax { get; set; }
        public string DailyOpenTime { get; set; }
        public string DailyCloseTime { get; set; }
        public string AfterNBrakestart { get; set; }
        public string AfternBreakend { get; set; }
        private ICollection<weekend> _weekend;
        public virtual ICollection<weekend> weekend
        {
            get { return _weekend ?? (_weekend = new List<weekend>()); }
            set { _weekend = value; }
        }
        private ICollection<HolyDay> _holyDay;
        public virtual ICollection<HolyDay> HolyDay
        {
            get { return _holyDay ?? (_holyDay = new List<HolyDay>()); }
            set { _holyDay = value; }
        }
        private ICollection<Room> _room;
        public virtual ICollection<Room> Room
        {
            get { return _room ?? (_room = new List<Room>()); }
            set { _room = value; }
        }
        private ICollection<Stores> _stores;
        public virtual ICollection<Stores> Stores
        {
            get { return _stores ?? (_stores = new List<Stores>()); }
            set { _stores = value; }
        }






        // كل عيادة في إيها العديد من المرضى و كل مريض في  إلو عيادة وحيدة 




        private ICollection<Patient.Patient> _patient;
        public virtual ICollection<Patient.Patient> Patients
        {

            get { return _patient ?? (_patient = new List<Patient.Patient>()); }
            set { _patient = value; }

        }








        private ICollection<Doctor> _doctor;
        public virtual ICollection<Doctor> Doctors
        {

            get { return _doctor ?? (_doctor = new List<Doctor>()); }
            set { _doctor = value; }
        }
        private ICollection<Nurse> _nurse;
        public virtual ICollection<Nurse> Nurses
        {
            get { return _nurse ?? (_nurse = new List<Nurse>()); }
            set { _nurse = value; }
        }


        private ICollection<Worker> _worker;
        public virtual ICollection<Worker> Workers
        {
            get { return _worker ?? (_worker = new List<Worker>()); }
            set { _worker = value; }
        }

        private ICollection<Suppliers> _suppliers;
        public virtual ICollection<Suppliers> Suppliers
        {
            get { return _suppliers ?? (_suppliers = new List<Suppliers>()); }
            set { _suppliers = value; }
        }

        private ICollection<Income> _income;
        public virtual ICollection<Income> Incomes
        {
            get { return _income ?? (_income = new List<Income>()); }
            set { _income = value; }
        }

        private ICollection<Spend> _spend;
        public virtual ICollection<Spend> Spends
        {
            get { return _spend ?? (_spend = new List<Spend>()); }
            set { _spend = value; }
        }

        


     } 




}
