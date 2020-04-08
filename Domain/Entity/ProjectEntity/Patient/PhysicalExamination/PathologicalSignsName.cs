using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
   public class PathologicalSignsName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }
        public decimal Cost { get; set; }


        private ICollection<PathologicalSigns> _pathologicalSigns; // المعاينة والملاحظة
        public virtual ICollection<PathologicalSigns> PathologicalSigns
        {

            get { return _pathologicalSigns ?? (_pathologicalSigns = new List<PathologicalSigns>()); }
            set { _pathologicalSigns = value; }
        }
    }
}
