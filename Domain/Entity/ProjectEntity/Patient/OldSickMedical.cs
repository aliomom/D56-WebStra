using System;

namespace Domain.Entity.ProjectEntity.Patient
{
    public class OldSickMedical
    {
        public virtual OldSick OldSick { get; set; }
        public int Id { get; set; }
        public string ComName { get; set; }
        public string MedicalType { get; set; }
        public string ActiveIngradiantName { get; set; }
        public string PricentOfActiveIngradiant { get; set; }
        public string StartDate { get; set; }
        public string DoseType { get; set; }
        public string Dose { get; set; }

    }
}