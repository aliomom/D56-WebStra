using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class Stores
    {
        public virtual Clinic.Clinic Clinic { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public virtual  StoreType  StoreType { get; set; }

        public virtual AspNetUser Storekeeper { get; set; }

        private ICollection<Stocks> _stocks;
        public virtual ICollection<Stocks> Stocks
        {

            get { return _stocks ?? (_stocks = new List<Stocks>()); }
            set { _stocks = value; }
        }

        private ICollection<Receipt> _receipt;
        public virtual ICollection<Receipt> Receipt
        {

            get { return _receipt ?? (_receipt = new List<Receipt>()); }
            set { _receipt = value; }

        }

        private ICollection<Order> _order;
        public virtual ICollection<Order> Order
        {

            get { return _order ?? (_order = new List<Order>()); }
            set { _order = value; }

        }



    }
}
