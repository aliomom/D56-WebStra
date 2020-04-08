using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity
{
   public class RadioGramType//نمط الصورة رنين طبقي أشعة ألخ 
    {
       

        public int Id { get; set; }
        public string RadioGramTypeName{ get; set; }
        private ICollection<RadiogramRefrance> _radiogramRefrance;
        public virtual ICollection<RadiogramRefrance> RadiogramRefrance
        {
            get { return _radiogramRefrance ?? (_radiogramRefrance = new List<RadiogramRefrance>()); }
            set { _radiogramRefrance = value; }
        }
        public string RadioGramDescription { get; set; }
    }
}
