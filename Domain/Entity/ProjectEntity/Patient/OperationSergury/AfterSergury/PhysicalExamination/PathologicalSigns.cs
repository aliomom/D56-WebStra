using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.PhysicalExamination
{
    public class PathologicalSigns
    {
        public virtual Inspection Inspection { get; set; }
        public int Id { get; set; }
        public string PathologicalSignName { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
    }
}