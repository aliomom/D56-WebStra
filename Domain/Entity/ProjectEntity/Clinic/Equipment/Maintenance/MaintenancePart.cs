using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.Maintenance
{
    public class MaintenancePart
    {
        public EquipmentMaintenance Maintenance { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
