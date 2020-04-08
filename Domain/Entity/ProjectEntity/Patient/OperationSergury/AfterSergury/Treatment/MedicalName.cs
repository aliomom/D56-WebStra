using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Treatment
{
   public class MedicalName
    {
        public int Id { get; set; }
        public string ComName { get; set; }
        public string CompanyName { get; set; }
        public string MedicalType { get; set; }
        public string ActiveIngradiantName { get; set; }
        public string PricentOfActiveIngradiant { get; set; }  
        public string DoseType { get; set; }
        public string Note { get; set; }

        public float Cost { get; set; }
    }
}
