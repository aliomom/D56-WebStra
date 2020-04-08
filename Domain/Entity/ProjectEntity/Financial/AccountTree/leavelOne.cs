using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree
{
   public class leavelOne
    {
        public int Id { get; set; }
        public string AccountId { get { return Id.ToString(); } set { } }
        public string Name { get; set; }
        private ICollection<levelTwo> _levelTwo { get; set; }
        public virtual ICollection<levelTwo> levelTwo
        {

            get { return _levelTwo ?? (_levelTwo = new List<levelTwo>()); }

        }



    }
}
