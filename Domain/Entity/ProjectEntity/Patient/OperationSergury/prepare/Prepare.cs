using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.prepare
{
    public class Prepare
    {
        public int Id { get; set; }
        public DateTime startAt { get; set; }
        public Nurse Nurse { get; set; }

        private ICollection<PrepareMedical> _prepareMedical;
        public virtual ICollection<PrepareMedical> PrepareMedical
        {

            get { return _prepareMedical ?? (_prepareMedical = new List<PrepareMedical>()); }
            set { _prepareMedical = value; }
        }

        private ICollection<CatheterVenous> _catheterVenous;
        public virtual ICollection<CatheterVenous> CatheterVenous
        {

            get { return _catheterVenous ?? (_catheterVenous = new List<CatheterVenous>()); }
            set { _catheterVenous = value; }
        }

        private ICollection<UrinaryCatheters> _urinaryCatheters;
        public virtual ICollection<UrinaryCatheters> UrinaryCatheters
        {

            get { return _urinaryCatheters ?? (_urinaryCatheters = new List<UrinaryCatheters>()); }
            set { _urinaryCatheters = value; }
        }

        public string Report { get; set; }








    }
}