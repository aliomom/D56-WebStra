using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial
{
   public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ConvertRate { get; set; }

        private ICollection<Invoice> _invoice { get; set; }
        public virtual ICollection<Invoice> Invoice
        {

            get { return _invoice ?? (_invoice = new List<Invoice>()); }

        }
    }
}
