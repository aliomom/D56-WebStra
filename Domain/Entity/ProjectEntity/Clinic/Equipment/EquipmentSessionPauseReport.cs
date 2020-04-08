namespace Domain.Entity.ProjectEntity.Clinic.Equipment
{
    public class EquipmentSessionPauseReport
    {
        public virtual TherapeuticEquipment.TherapeuticEquipmentSession EquipmentSession { get; set; }

        public int Id { get; set; }
        public string pause { get; set; }
        public string Reasone { get; set; }
        public string play { get; set; }
    }
}