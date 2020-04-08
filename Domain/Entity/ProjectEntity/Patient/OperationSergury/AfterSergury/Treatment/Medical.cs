using Domain.Entity.ProjectEntity.Patient.Treatment;
using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Treatment
{
    public class Medical
    {
       
        public AfterSergury  AfterSergury { get; set; }
        public int Id { get; set; }
        public MedicalName MedicalName { get; set; }
        public DateTime StartDate { get; set; }
        public string Period { get; set; }
        public string Dose { get; set; }
        public string Note { get; set; }
    }
}