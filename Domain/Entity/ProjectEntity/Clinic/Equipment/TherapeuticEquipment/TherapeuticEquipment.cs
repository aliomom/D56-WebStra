using Domain.Entity.ProjectEntity.Clinic.Equipment.Maintenance;
using Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment.Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment
{
   public class TherapeuticEquipment
    {
        public int Id { get; set; }
        public string UniqCode { get; set; }
        public string Description { get; set; }
        public virtual Room Room { get; set; }
        public string ManufactureCompany { get; set; }
        public string ManufactureCompanyEmail { get; set; }
        public string ManufactureCompanyPhone { get; set; }
        public string ManufactureCompanyAddress { get; set; }
        public string MaintenanceContactPerson { get; set; }
        public string MaintenancePhone { get; set; }
        public byte[] UserGuide { get; set; }
        public string StartUseDate { get; set; }

        public string EndUseDate { get; set; }
        public string IsBesy { get; set; }


        public string Note { get; set; }


        private ICollection<TherapeuticEquipmentSessionName> _equipmentSessionName { get; set; }
        public virtual ICollection<TherapeuticEquipmentSessionName> TherapeuticEquipmentSessionName
        {

            get { return _equipmentSessionName ?? (_equipmentSessionName = new List<TherapeuticEquipmentSessionName>()); }

        }

      

        public int DepreciationPeriod { get; set; }//mounth 
        public int DepreciationOnOperatingTimes { get; set; }

        private ICollection<UndirectOperationName> _undirectOperationName { get; set; }
        public virtual ICollection<UndirectOperationName> UndirectOperationName
        {

            get { return _undirectOperationName ?? (_undirectOperationName = new List<UndirectOperationName>()); }

        }


        private ICollection<EquipmentMaintenance> _maintenance { get; set; }
        public virtual ICollection<Maintenance.EquipmentMaintenance> Maintenance
        {

            get { return _maintenance ?? (_maintenance = new List<Maintenance.EquipmentMaintenance>()); }

        }





    }
}
