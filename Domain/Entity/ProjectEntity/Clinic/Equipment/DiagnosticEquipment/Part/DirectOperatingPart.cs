namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment.Part
{
    public class DirectOperatingPart
    {
        public virtual DirectOperatingPartName DirectOperatingPartName { get; set; }
        public int Id { get; set; }
        public string CodeInStuck { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }
    }
}