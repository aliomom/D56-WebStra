namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.RadioGram
{
    public class RadiogramRefrance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }
        public string Description { get; set; }
        public RadioGramType  RadioGramType { get; set; }
    }
}