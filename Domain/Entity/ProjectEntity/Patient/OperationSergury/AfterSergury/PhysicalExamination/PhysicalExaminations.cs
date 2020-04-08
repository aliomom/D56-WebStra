using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.PhysicalExamination
{
    public class PhysicalExaminations
    {
        public int Id { get; set; }
        public virtual AfterSergury AfterSergury { get; set; }

        private ICollection<Inspection> _inspections; // المعاينة والملاحظة
        public virtual ICollection<Inspection> Inspections
        {

            get { return _inspections ?? (_inspections = new List<Inspection>()); }
            set { _inspections = value; }
        }
        private ICollection<BodyExaminations> _bodyExamination;//الفحص الجسدي
        public virtual ICollection<BodyExaminations> BodyExamination
        {

            get { return _bodyExamination ?? (_bodyExamination = new List<BodyExaminations>()); }
            set { _bodyExamination = value; }
        }

        private ICollection<AuxiliaryExaminationDevices> _auxiliaryExaminationDevices;//استخدام أدوات فحص مكملة
        public virtual ICollection<AuxiliaryExaminationDevices> AuxiliaryExaminationDevices
        {

            get { return _auxiliaryExaminationDevices ?? (_auxiliaryExaminationDevices = new List<AuxiliaryExaminationDevices>()); }
            set { _auxiliaryExaminationDevices = value; }
        }

        public string Note { get; set; }

    }
}