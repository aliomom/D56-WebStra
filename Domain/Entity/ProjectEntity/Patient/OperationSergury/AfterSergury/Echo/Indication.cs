using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
   public class Indication
    {
        public int Id { get; set; }
        public IndicationName Name { get; set; }
        public string Description { get; set; }
        private ICollection<ModeAnd2D> _modeAnd2D;
        public virtual ICollection<ModeAnd2D> ModeAnd2Ds
        {
            get { return _modeAnd2D ?? (_modeAnd2D = new List<ModeAnd2D>()); }
            set { _modeAnd2D = value; }
        }

        private ICollection<Doppler> _doppler;
        public virtual ICollection<Doppler> Doppler
        {
            get { return _doppler ?? (_doppler = new List<Doppler>()); }
            set { _doppler = value; }
        }
    }
}
