using System;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class Spend
    {
        public virtual Clinic.Clinic  Clinic { get; set; }
        public int Id { get; set; }
        public string DateTime { get; set; }
        public string Statement { get; set; }
        public float Value { get; set; }

    }
}