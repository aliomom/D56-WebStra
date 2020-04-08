using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.PhysicalExamination
{
    public class AuxiliaryExaminationDevices
    {
        public virtual PhysicalExaminations PhysicalExamination { get; set; }

        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }

        public DateTime DateTime { get; set; }
        public string Value { get; set; }
        public string Note { get; set; }
    }
}