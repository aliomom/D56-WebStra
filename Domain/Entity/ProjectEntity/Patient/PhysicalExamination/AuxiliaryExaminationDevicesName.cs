using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
   public class AuxiliaryExaminationDevicesName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }
        public decimal Cost { get; set; }

        private ICollection<AuxiliaryExaminationDevices> _auxiliaryExaminationDevices; 
        public virtual ICollection<AuxiliaryExaminationDevices> AuxiliaryExaminationDevices
        {

            get { return _auxiliaryExaminationDevices ?? (_auxiliaryExaminationDevices = new List<AuxiliaryExaminationDevices>()); }
            set { _auxiliaryExaminationDevices = value; }
        }

    }
}
