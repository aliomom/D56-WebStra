using System;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
    public class AuxiliaryExaminationDevices
    {
        public virtual PhysicalExaminations PhysicalExamination { get; set; }

        public int Id { get; set; }
        public virtual AuxiliaryExaminationDevicesName AuxiliaryExaminationDevicesName { get; set; }
        public string DateTime { get; set; }
        public string Value { get; set; }
        public string Note { get; set; }
    }
}