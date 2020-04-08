namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Endoscopys
{
    public class EndoscopysImage
    {
        public Endoscopys Endoscopys { get; set; }
        public int Id { get; set; }
        public byte[] image { get; set; }
        public string Report { get; set; }

    }
}