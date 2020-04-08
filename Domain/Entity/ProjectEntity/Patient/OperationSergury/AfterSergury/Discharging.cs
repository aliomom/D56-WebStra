using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury
{
    public class Discharging
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public AfterSergury AfterSergury { get; set; }
        public string DischargeDestination { get; set; }
        public string Note { get; set; }






    }
}