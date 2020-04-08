namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
    public class Psychology
    {
        public int Id { get; set; }
        public virtual PsychologyName PsychologyName { get; set; }
        public virtual Treatments  Treatments { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public string note { get; set; }
        public string NextSession { get; set; }
    }
}