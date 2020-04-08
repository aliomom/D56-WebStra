using System;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
    public class PathologicalSigns
    {
        public virtual PhysicalExaminations  PhysicalExaminations { get; set; }
        public int Id { get; set; }
        public virtual PathologicalSignsName  PathologicalSignsName { get; set; }


        public string Value { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
    }
}