using Domain.Entity.ProjectEntity.Patient;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class Order
    {
        public int Id { get; set; }
        
        public string OrderState { get; set; }//request - delevered
        
        public string RequestDateTime { get; set; }

        public int DeleveredDateTime { get; set; }
        private ICollection<Stores> _stores;
        public virtual ICollection<Stores> Stores
        {
            get { return _stores ?? (_stores = new List<Stores>()); }
            set { _stores = value; }
        }

        private ICollection<OrderItem> _orderItem;
        public virtual ICollection<OrderItem> OrderItem
        {
            get { return _orderItem ?? (_orderItem = new List<OrderItem>()); }
            set { _orderItem = value; }
        }


      

    }
}
