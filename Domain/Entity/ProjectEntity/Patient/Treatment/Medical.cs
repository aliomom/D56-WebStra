using Domain.Entity.ProjectEntity.Patient.Treatment;
using System;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
    public class Medical
    {
       
        public Treatments Treatments { get; set; }
        public int Id { get; set; }
        public virtual MedicalName MedicalName { get; set; }
        public string StartDate { get; set; }
        public string Period { get; set; }
        public string Dose { get; set; }
        public string Note { get; set; }
    }
}