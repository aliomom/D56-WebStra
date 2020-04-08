namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment
{
    public class DevicesSetting
    {
        public virtual TherapeuticEquipmentSession DiagnosticEquipmentSession { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Note { get; set; }
        public virtual DevicesSettingName DevicesSettingName { get; set; }

    }
}