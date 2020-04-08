using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree.FixedAccount
{
   public class Customers
    {

        public string stitchWith  { get; set; }
        public virtual Patient.Patient  Patient { get; set; }
        


    }
}
