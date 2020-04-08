using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.Anlysis
{
   public class AnlysisType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Note { get; set; }
        
        private ICollection<Anlyis> _anlyis;
        public virtual ICollection<Anlyis> Anlyis
        {
            get { return _anlyis ?? (_anlyis = new List<Anlyis>()); }
            set { _anlyis = value; }
        }

    }
}
