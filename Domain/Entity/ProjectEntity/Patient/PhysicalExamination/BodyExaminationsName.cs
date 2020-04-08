using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
   public class BodyExaminationsName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }
        public decimal Cost { get; set; }

        private ICollection<BodyExaminations> _bodyExaminations;
        public virtual ICollection<BodyExaminations> BodyExaminations
        {

            get { return _bodyExaminations ?? (_bodyExaminations = new List<BodyExaminations>()); }
            set { _bodyExaminations = value; }
        }

    }
}
