using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial
{
   public class Invoice
    {
        public int Id { get; set; }
        public virtual Patient.Patient Patient { get; set; }
        public string DateTime { get; set; }
        public virtual PaymentType  PaymentType { get; set; }
        public virtual Currency Currency  { get; set; }





    }
}
