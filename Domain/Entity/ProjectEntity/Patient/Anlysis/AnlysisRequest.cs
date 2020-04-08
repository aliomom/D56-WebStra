using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.Anlysis
{
   public class AnlysisRequest
    {
        public virtual Anlysis.Anlyis Anlysis { get; set; }
        public int Id { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }
        
    }
}
