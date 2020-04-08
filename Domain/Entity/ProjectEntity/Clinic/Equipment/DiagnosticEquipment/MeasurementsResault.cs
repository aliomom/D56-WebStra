namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment
{
    public class MeasurementsResault
    {
        public virtual DiagnosticEquipmentSession  DiagnosticEquipmentSession { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Note { get; set; }
        public virtual MeasurementsName MeasurementsName { get; set; }

    }
}
