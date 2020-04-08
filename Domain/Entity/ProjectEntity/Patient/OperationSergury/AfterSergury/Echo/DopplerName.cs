using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
   public class DopplerName
    {
        public IndicationName IndicationName { get; set; }
        public int Id { get; set; }
        public string MeasurmentName { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }

        private ICollection<Doppler> _doppler;
        public virtual ICollection<Doppler> Doppler
        {
            get { return _doppler ?? (_doppler = new List<Doppler>()); }
            set { _doppler = value; }
        }

    }
