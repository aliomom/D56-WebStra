using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
   public class IndicationName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        private ICollection<DopplerName> _dopplerName;
        public  ICollection<DopplerName> DopplerNames
        {
            get { return _dopplerName ?? (_dopplerName = new List<DopplerName>()); }
            set { _dopplerName = value; }
        }
        private ICollection<ModeAnd2DName> _modeAnd2DName;
        public ICollection<ModeAnd2DName> ModeAnd2DName
        {
            get { return _modeAnd2DName ?? (_modeAnd2DName = new List<ModeAnd2DName>()); }
            set { _modeAnd2DName = value; }
        }

        public ICollection<Indication> Idecations
        {
            get { return _idecations ?? (_idecations = new List<Indication>()); }
            set { _idecations = value; }
        }


    }
}
