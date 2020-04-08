using Domain.Entity.ProjectEntity.Clinic;
using Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment;
using Domain.Entity.ProjectEntity.Financial;
using Domain.Entity.ProjectEntity.Patient.Anlysis;
using Domain.Entity.ProjectEntity.Patient.PhysicalExamination;
using Domain.Entity.ProjectEntity.Patient.Treatment;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient
{
    public class Review
    {
        public int ID { get; set; }
    
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Nurse Nurse { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Room Room { get; set; }

        public virtual Order Order { get; set; }



        private ICollection<PhysicalExaminations> _physicalExaminations;
        public virtual ICollection<PhysicalExaminations> PhysicalExaminations
        {

            get { return _physicalExaminations ?? (_physicalExaminations = new List<PhysicalExaminations>()); }
            set { _physicalExaminations = value; }
        }

        private ICollection<Anlyis> _bloodAnlyis;
        public virtual ICollection<Anlyis> BloodAnlyis
        {

            get { return _bloodAnlyis ?? (_bloodAnlyis = new List<Anlyis>()); }
            set { _bloodAnlyis = value; }
        }



        private ICollection<Radiogram> _radiogram;
        public virtual ICollection<Radiogram> Radiogram
        {

            get { return _radiogram ?? (_radiogram = new List<Radiogram>()); }
            set { _radiogram = value; }
        }
        private ICollection<DiagnosticEquipmentSession> _diagnosticEquipmentSession;
        public virtual ICollection<DiagnosticEquipmentSession> DiagnosticEquipmentSession
        {

            get { return _diagnosticEquipmentSession ?? (_diagnosticEquipmentSession = new List<DiagnosticEquipmentSession>()); }
            set { _diagnosticEquipmentSession = value; }
        }



        private ICollection<Diagnoses> _diagnoses;
        public virtual ICollection<Diagnoses> Diagnoses
        {

            get { return _diagnoses ?? (_diagnoses = new List<Diagnoses>()); }
            set { _diagnoses = value; }
        }

        private ICollection<Treatments> _treatment;
        public virtual ICollection<Treatments> Treatment
        {

            get { return _treatment ?? (_treatment = new List<Treatments>()); }
            set { _treatment = value; }
        }

        public string NextSession { get; set; }

       
    }
}
