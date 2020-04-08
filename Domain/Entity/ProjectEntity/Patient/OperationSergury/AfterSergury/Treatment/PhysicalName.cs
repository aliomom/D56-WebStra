namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Treatment
{
    public class PhysicalName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] GuideFile { get; set; }
        public float Cost { get; set; }
    }
}