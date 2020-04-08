using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient
{
    public class OldSick
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfDescove { get; set; }
        public virtual Patient patient { get; set; }
        private ICollection<OldSickMedical> _oldsickMedical;

        public virtual ICollection<OldSickMedical> OldSickMedical
        {
            get { return _oldsickMedical ?? (_oldsickMedical = new List<OldSickMedical>()); }
            set { _oldsickMedical = value; }
        }


    }
}