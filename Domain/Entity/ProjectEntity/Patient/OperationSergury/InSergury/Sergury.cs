using Domain.Entity.ProjectEntity.Clinic;
using Domain.Entity.ProjectEntity.Patient;
using Domain.Entity.ProjectEntity.Patient.OperationSergury.prepare;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.InSergury
{
    public class Sergury
    {
        public int Id { get; set; }
        public DateTime StartDateAndTime { get; set; }
        public DateTime EndDateAndTime { get; set; }
        public Review  Review{ get; set; }
        public Doctor MajorDoctors { get; set; }
        public Doctor AssistantDoctors1 { get; set; }
        public Doctor AssistantDoctors2 { get; set; }
        public Nurse Nurses { get; set; }
        public string DescriptionBefore { get; set; }
        private ICollection<SerguryMedical> _serguryMedical;
        public virtual ICollection<SerguryMedical> SerguryMedical
        {

            get { return _serguryMedical ?? (_serguryMedical = new List<SerguryMedical>()); }
            set { _serguryMedical = value; }
        }

        private ICollection<Anesthetics> _anesthetics;
        public virtual ICollection<Anesthetics> SerguryAnesthetics
        {

            get { return _anesthetics ?? (_anesthetics = new List<Anesthetics>()); }
            set { _anesthetics = value; }
        }
        public string AnestheticsReport { get; set; }
        private ICollection<Prepare> _prepare;
        public virtual ICollection<Prepare> Prepare
        {

            get { return _prepare ?? (_prepare = new List<Prepare>()); }
            set { _prepare = value; }
        }

        public virtual AfterSergury.AfterSergury AfterSergury { get; set; }

        public string DrugReport { get; set; }
        public string Report { get; set; }
        public string ReportAfter5Day { get; set; }
        public string ReportAfter10Day { get; set; }
        public string ReportAfter20Day { get; set; }
        public String ReportAfter30Day { get; set; }


    }
}