using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment.Part
{
    public class UndirectOperationName
    {
        public virtual TreatmentEquipment TreatmentEquipment { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManufactureCompany { get; set; }
        public string ManufactureCompanyEmail { get; set; }
        public string ManufactureCompanyPhone { get; set; }
        public string ManufactureCompanyAddress { get; set; }
        public string MaintenanceContactPerson { get; set; }
        public string MaintenancePhone { get; set; }
        public byte[] UserGuide { get; set; }
        public string Note { get; set; }
        public int DepreciationPeriod { get; set; }//mounth 
        public int DepreciationOnOperatingTimes { get; set; }//onec
        private ICollection<UndirectOperation> _changeablespart;
        public ICollection<UndirectOperation> ChangeableParts
        {

            get { return _changeablespart ?? (_changeablespart = new List<UndirectOperation>()); }
            set { _changeablespart = value; }
        }

        public decimal Cost { get; set; }

    } 
}
