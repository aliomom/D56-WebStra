using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
   public class PsychologyName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public decimal Cost { get; set; }

        private ICollection<Psychology> _psychology;
        public virtual ICollection<Psychology> Psychology
        {

            get { return _psychology ?? (_psychology = new List<Psychology>()); }
            set { _psychology = value; }
        }

    }
}
