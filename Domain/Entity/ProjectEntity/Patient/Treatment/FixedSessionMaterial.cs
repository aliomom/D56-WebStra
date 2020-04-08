using Domain.Entity.ProjectEntity.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
   public class FixedSessionMaterial
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual Material Material { get; set; }
        public virtual UnitsAndPrice unit { get; set; }

        public virtual Treatments Treatments { get; set; }
        public string Note { get; set; }

    }
}
