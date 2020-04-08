namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
    public class Doppler
    {
        public int Id { get; set; }
        public DopplerName MeasurmentName { get; set; }

        public string  Value { get; set; }
        public virtual  Indication  Indication { get; set; }
    }
}