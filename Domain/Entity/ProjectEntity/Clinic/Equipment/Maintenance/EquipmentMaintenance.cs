using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.Maintenance
{
   public class EquipmentMaintenance
    {
        public virtual DiagnosticEquipment.DiagnosticEquipment DiagnosticEquipment { get; set; }
        public virtual TherapeuticEquipment.TherapeuticEquipment TherapeuticEquipment { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
        public string Reasons { get; set; }
        public string MainteneceWorker { get; set; }
        public string Date { get; set; }
        private ICollection<MaintenancePart> _maintenancePart;
        public ICollection<MaintenancePart> MaintenancePart
        {

            get { return _maintenancePart ?? (_maintenancePart = new List<MaintenancePart>()); }
            set { _maintenancePart = value; }
        }


    }
}
