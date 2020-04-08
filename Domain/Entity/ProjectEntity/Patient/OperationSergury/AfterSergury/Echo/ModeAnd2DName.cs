using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
   public class ModeAnd2DName
    {
        public IndicationName  IndicationName { get; set; }
        public int Id { get; set; }
        public string MeasurmentName { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }
        private ICollection<ModeAnd2D> _modeAnd2D;
        public virtual ICollection<ModeAnd2D> ModeAnd2Ds
        {
            get { return _modeAnd2D ?? (_modeAnd2D = new List<ModeAnd2D>()); }
            set { _modeAnd2D = value; }
        }
    }
}
