namespace Domain.Entity.ProjectEntity.Clinic
{
    public class HolyDay
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string  IsPaid { get; set; }


        public virtual Clinic Clinic { get; set; }
    }
}