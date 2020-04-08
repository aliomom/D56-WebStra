namespace Domain.Entity.ProjectEntity.Clinic
{
    public class weekend
    {
        public virtual Clinic Clinic { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
    }
}