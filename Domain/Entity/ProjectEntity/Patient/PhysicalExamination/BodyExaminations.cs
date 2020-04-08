using System;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
    public class BodyExaminations
    {

        public virtual PhysicalExaminations  PhysicalExamination { get; set; }
        public int Id { get; set; }
        public BodyExaminationsName BodyExaminationsName { get; set; }
      
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }


    }
}