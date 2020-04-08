using Domain.Entity.ProjectEntity.Financial;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment
{
    public class SessionMaterial
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual Material Material { get; set; }
        public virtual UnitsAndPrice unit { get; set; }

        public virtual TherapeuticEquipmentSession TherapeuticEquipmentSession { get; set; }
        public string Note { get; set; }
    }
}