namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
    public class ModeAnd2D
    {
        public int Id { get; set; }
        public ModeAnd2DName ModeAnd2DName { get; set; }
        public string Observed { get; set; }
        public string Normal { get; set; }
        public string Value { get; set; }
        public virtual Indication Indication { get; set; }
    }
}