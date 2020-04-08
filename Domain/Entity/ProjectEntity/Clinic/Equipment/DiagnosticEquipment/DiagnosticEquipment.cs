
using Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment.Part;
using Domain.Entity.ProjectEntity.Clinic.Equipment.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment
{
   public class DiagnosticEquipment
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


        private ICollection<DiagnosticEquipmentSessionName> _equipmentSessionName { get; set; }
        public virtual ICollection<DiagnosticEquipmentSessionName> TherapeuticEquipmentSessionName
        {

            get { return _equipmentSessionName ?? (_equipmentSessionName = new List<DiagnosticEquipmentSessionName>()); }

        }

      

        public int DepreciationPeriod { get; set; }//mounth 
        public int DepreciationOnOperatingTimes { get; set; }

        private ICollection<UndirectOperationName> _undirectOperationName { get; set; }
        public virtual ICollection<UndirectOperationName> UndirectOperationName
        {

            get { return _undirectOperationName ?? (_undirectOperationName = new List<UndirectOperationName>()); }

        }


        private ICollection<EquipmentMaintenance> _maintenance { get; set; }
        public virtual ICollection<EquipmentMaintenance> Maintenance
        {

            get { return _maintenance ?? (_maintenance = new List<EquipmentMaintenance>()); }

        }





    }
}
