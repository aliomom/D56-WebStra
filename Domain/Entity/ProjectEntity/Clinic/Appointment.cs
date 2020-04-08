using Domain.Entity.ProjectEntity.Patient;
using System;

namespace Domain.Entity.ProjectEntity.Clinic
{
    public class Appointment
    {
        public virtual AspNetUser AspNetUser { get; set; }
        public int Id { get; set; }
        public virtual Patient.Patient patient { get; set; }
        public string Symptoms { get; set; }
        public virtual Doctor Doctor { get; set; }
       
        public string DateTime { get; set; }
        public string Note { get; set; }
        public virtual Review Review { get; set; }
       




    }
}