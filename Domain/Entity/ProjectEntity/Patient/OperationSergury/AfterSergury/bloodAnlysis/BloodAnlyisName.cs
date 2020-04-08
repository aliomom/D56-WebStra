using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.bloodAnlysis
{
    public class BloodAnlyisName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observed { get; set; }
        public int ForMan { get; set; }
        public int ForWoman { get; set; }
        public int ForKids { get; set; }
        public int ForOldMen { get; set; }
        private ICollection<BloodAnlyis> _bloodAnlyis;
        public virtual ICollection<BloodAnlyis> BloodAnlyis
        {
            get { return _bloodAnlyis ?? (_bloodAnlyis = new List<BloodAnlyis>()); }
            set { _bloodAnlyis = value; }
        }
        public string Note { get; set; }

    }
}