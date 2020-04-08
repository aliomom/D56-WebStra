using System;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class Income
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public float value { get; set; }
        public virtual Clinic.Clinic Clinic { get; set; }
    }
}