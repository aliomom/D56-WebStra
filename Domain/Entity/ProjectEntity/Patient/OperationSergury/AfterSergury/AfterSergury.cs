using Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.PhysicalExamination;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury
{
    public class AfterSergury
    {
        public int Id { get; set; }
        public string PatiantState { get; set; }
        private ICollection<PhysicalExaminations> _afterSerguryPhysicalExaminationPhysicalExaminations;
        public virtual ICollection<PhysicalExaminations> AfterSerguryPhysicalExaminationPhysicalExaminations
        {

            get { return _afterSerguryPhysicalExaminationPhysicalExaminations ?? (_afterSerguryPhysicalExaminationPhysicalExaminations = new List<PhysicalExaminations>()); }
            set { _afterSerguryPhysicalExaminationPhysicalExaminations = value; }
        }
        public string Allow { get; set; }
        public string NotAlow { get; set; }
        public ToDoForPatient ToDoForPatient { get; set; }
        public DateTime ExpectAnExitTime { get; set; }

        public Discharging Discharging { get; set; }

    }
}