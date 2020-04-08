using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
    public class PhysicalName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TargetoOrgan { get; set; }
        public string Description { get; set; }
        public byte[] GuideFile { get; set; }
        public decimal Cost { get; set; }
        private ICollection<Physical> _physical;
        public virtual ICollection<Physical> Physical
        {

            get { return _physical ?? (_physical = new List<Physical>()); }
            set { _physical = value; }
        }

    }
}