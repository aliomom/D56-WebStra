using Domain.Entity.ProjectEntity.Patient.OperationSergury.InSergury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Treatment
{
   public class Treatments
    {
        public int Id { get; set; }
        public AfterSergury  AfterSergury { get; set; }
        public DateTime  DateTime { get; set; }
        private ICollection<Medical> _medical;
        public virtual ICollection<Medical> Medical
        {

            get { return _medical ?? (_medical = new List<Medical>()); }
            set { _medical = value; }
        }

        private ICollection<Physical> _physical;
        public virtual ICollection<Physical> Physical
        {

            get { return _physical ?? (_physical = new List<Physical>()); }
            set { _physical = value; }
        }
        private ICollection<RadiationTherapy> _radiationTherapy;
        public virtual ICollection<RadiationTherapy> RadiationTherapy
        {

            get { return _radiationTherapy ?? (_radiationTherapy = new List<RadiationTherapy>()); }
            set { _radiationTherapy = value; }
        }

        private ICollection<Psychology> _psychology;
        public virtual ICollection<Psychology> Psychology
        {

            get { return _psychology ?? (_psychology = new List<Psychology>()); }
            set { _psychology = value; }
        }

        private ICollection<Sergury> _sergury;
        public virtual ICollection<Sergury> Sergury
        {

            get { return _sergury ?? (_sergury = new List<Sergury>()); }
            set { _sergury = value; }
        }

        private ICollection<AnotherTreatment> _anotherTreatment;
        public virtual ICollection<AnotherTreatment> AnotherTreatment
        {

            get { return _anotherTreatment ?? (_anotherTreatment = new List<AnotherTreatment>()); }
            set { _anotherTreatment = value; }
        }
    }
}
