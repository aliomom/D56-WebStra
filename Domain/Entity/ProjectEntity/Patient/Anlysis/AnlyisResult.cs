using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.Anlysis
{
    public class AnlyisResult
    {
        public int Id { get; set; }
        
        public virtual Anlyis Anlyis { get; set; }
        public virtual AnlyisName  AnlyisName { get; set; }
        public string Value { get; set; }
        public string Note { get; set; }
     
       
    }
}