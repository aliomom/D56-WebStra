using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Financial
{
   public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual Material Material { get; set; }
        public virtual UnitsAndPrice unit { get; set; }
        
        public virtual Order Order { get; set; }
        public string Note { get; set; }




    }
}