using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
    public class RadiationTherapy
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Treatments  Treatments { get; set; }
        public string Discription { get; set; }
        public string Report { get; set; }
        public decimal Cost { get; set; }
    }
}
