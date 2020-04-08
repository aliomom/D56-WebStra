using Domain.Entity.ProjectEntity.Patient.Treatment;
using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.prepare
{
    public class PrepareMedical
    {
        public Prepare Prepare { get; set; }
        public int Id { get; set; }
        public MedicalName MedicalName { get; set; }
        public string way { get; set; }
        public Nurse Nurse { get; set; }
        public DateTime DateTime { get; set; }
        public string Dose { get; set; }
        public string Note { get; set; }
    }
}