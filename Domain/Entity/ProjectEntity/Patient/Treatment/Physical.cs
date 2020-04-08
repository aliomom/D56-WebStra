using System;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
    public class Physical
    {
        public Treatments Treatments { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PatientStateBefore { get; set; }
        public virtual PhysicalName  PhysicalName { get; set; }
        public string Period { get; set; }

        public string PatientStateDuringSession { get; set; }
        public string Tools1 { get; set; }
        public string Tools2 { get; set; }
        public string Tools3 { get; set; }
        public string Report { get; set; }
        public string PatientStateAfter { get; set; }
        public string NextSession { get; set; }

    }
}