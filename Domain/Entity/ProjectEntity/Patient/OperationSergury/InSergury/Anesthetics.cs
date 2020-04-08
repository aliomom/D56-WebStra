using Domain.Entity.ProjectEntity.Patient.Treatment;
using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.InSergury
{
    public class Anesthetics
    {
        public Sergury Sergury { get; set; }
        public int Id { get; set; }
        public MedicalName MedicalName { get; set; }
        public Nurse Nurse { get; set; }
        public DateTime StartDate { get; set; }
        public string Period { get; set; }
        public string Dose { get; set; }
        public string Note { get; set; }
    }
}