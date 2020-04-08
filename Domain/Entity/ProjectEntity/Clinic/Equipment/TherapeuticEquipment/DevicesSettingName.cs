using Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment
{
    public class DevicesSettingName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Normal { get; set; }
        public string abserval { get; set; }
        public TherapeuticEquipmentSessionName DiagnosticEquipmentSessionName { get; set; }
        private ICollection<DevicesSetting> _devicesSetting { get; set; }
        public virtual ICollection<DevicesSetting> DevicesSetting
        {

            get { return _devicesSetting ?? (_devicesSetting = new List<DevicesSetting>()); }

        }
    }
}