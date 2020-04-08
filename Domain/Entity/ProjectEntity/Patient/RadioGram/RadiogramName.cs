namespace Domain.Entity.ProjectEntity
{
    public class RadiogramRefrance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] image { get; set; }
        public string Description { get; set; }
        public RadioGramType  RadioGramType { get; set; }
        public decimal Cost { get; set; }
    }
}