using System;
using System.Collections.Generic;
using Domain.Entity.ProjectEntity.Patient;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.bloodAnlysis
{
    public class BloodAnlyis
    {
        public virtual AfterSergury AfterSergury { get; set; }
        public int Id { get; set; }
        public BloodAnlyisName BloodAnlyisName { get; set; }
        public string Observed { get; set; }
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
        


    }
}