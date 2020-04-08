using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial
{
   public class Suppliers
    {
        public virtual Clinic.Clinic Clinic { get; set; }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Whatsup { get; set; }
        public string fax { get; set; }
        public string HomePage { get; set; }
        public decimal Balance { get; set; }

        private ICollection<Receipt> _receipt;
        public ICollection<Receipt> Receipt
        {

            get { return _receipt ?? (_receipt = new List<Receipt>()); }
            set { _receipt = value; }
        }



    }
}
