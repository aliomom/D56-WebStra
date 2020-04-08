using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.prepare
{
    public class UrinaryCatheters
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int CountOfChangingBag { get; set; }
        public string Description { get; set; }
    }
}