using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial
{
   public class Stocks
    {
        public virtual Stores Stores { get; set; }//primary
        public virtual Material Material { get; set; }
        public int Quantity { get; set; }

    }
}
