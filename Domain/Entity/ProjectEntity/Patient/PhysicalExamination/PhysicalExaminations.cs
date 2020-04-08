using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.PhysicalExamination
{
    public class PhysicalExaminations
    {
        public int Id { get; set; }
        public virtual Review Reviwe { get; set; }

        private ICollection<PathologicalSigns> _pathologicalSigns; // المعاينة والملاحظة
        public virtual ICollection<PathologicalSigns> PathologicalSigns
        {

            get { return _pathologicalSigns ?? (_pathologicalSigns = new List<PathologicalSigns>()); }
            set { _pathologicalSigns = value; }
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