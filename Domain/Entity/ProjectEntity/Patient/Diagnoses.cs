using Domain.Entity.ProjectEntity.Patient;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity
{
    public class Diagnoses
    {
        public virtual  Review Review { get; set; }
        public int Id { get; set; }
        
        public string dateTime { get; set; }
        public string DiagnosesType { get; set; }
        public string Diagnises { get; set; }
        

      
    }
}
