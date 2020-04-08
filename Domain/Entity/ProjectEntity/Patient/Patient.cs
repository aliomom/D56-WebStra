using Domain.Entity.ProjectEntity.Clinic;
using Domain.Entity.ProjectEntity.Financial;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient
{
    public class Patient
    {
        public int ID { get; set; }
        public string stitchWith { get; set; }
        public int AccountId { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public string CityAddress { get; set; }
        public string StreetAddress { get; set; }
        public string NearAdreess { get; set; }
        public string MobileNumber { get; set; }
        public string Phone { get; set; }
        public virtual Clinic.Clinic Clinic { get; set; }
        public DateTime  DOB { get; set; }
        public string BloodType { get; set; }
        private ICollection<OldSick> _oldsick;
        public virtual ICollection<OldSick> OldSicks
        {
            get { return _oldsick ?? (_oldsick = new List<OldSick>()); }
            set { _oldsick = value; }
        }
        private ICollection<Appointment> _appointments;
        public  ICollection<Appointment> Appointments
        {

            get { return _appointments ?? (_appointments = new List<Appointment>()); }
            set { _appointments = value; }
        }
        private ICollection<Review> _treatmentSessions;
        public ICollection<Review> TreatmentSessions
        {
            get { return _treatmentSessions ?? (_treatmentSessions = new List<Review>()); }
            set { _treatmentSessions = value; }
        }

        private ICollection<Order> _order { get; set; }
        public virtual ICollection<Order> Order
        {

            get { return _order ?? (_order = new List<Order>()); }

        }

        private ICollection<Invoice> _invoice { get; set; }
        public virtual ICollection<Invoice> Invoice
        {

            get { return _invoice ?? (_invoice = new List<Invoice>()); }

        }




    }
}