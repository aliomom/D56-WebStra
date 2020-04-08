using Domain.Entity.ProjectEntity.Clinic;
using Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.Treatment
{
   public class Treatments
    {
        public int Id { get; set; }
        public Review Review { get; set; }
        public string  DateTime { get; set; }
        public string LongTreatmentPlan { get; set; }
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

        private ICollection<TherapeuticEquipmentSession> _treatmentEquipment;
        public virtual ICollection<TherapeuticEquipmentSession> TherapeuticEquipmentSession
        {

            get { return _treatmentEquipment ?? (_treatmentEquipment = new List<TherapeuticEquipmentSession>()); }
            set { _treatmentEquipment = value; }
        }

        private ICollection<AnotherTreatment> _anotherTreatment;
        public virtual ICollection<AnotherTreatment> AnotherTreatment
        {

            get { return _anotherTreatment ?? (_anotherTreatment = new List<AnotherTreatment>()); }
            set { _anotherTreatment = value; }


        }


        private ICollection<FixedSessionMaterial> _fixedSessionMaterial { get; set; }
        public virtual ICollection<FixedSessionMaterial> FixedSessionMaterial
        {

            get { return _fixedSessionMaterial ?? (_fixedSessionMaterial = new List<FixedSessionMaterial>()); }

        }

        private ICollection<SessionMaterial> _sessionMaterial { get; set; }
        public virtual ICollection<SessionMaterial> SessionMaterial
        {

            get { return _sessionMaterial ?? (_sessionMaterial = new List<SessionMaterial>()); }

        }


    }
}
