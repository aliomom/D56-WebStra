using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class PaymentType
    {
        public int Id { get; set; }
        public int PaymentTypeName { get; set; }
        public string Note { get; set; }
        private ICollection<Invoice> _invoice { get; set; }
        public virtual ICollection<Invoice> Invoice
        {

            get { return _invoice ?? (_invoice = new List<Invoice>()); }

        }
    }
}