using Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment.Part;
using Domain.Entity.ProjectEntity.Financial;
using Domain.Entity.ProjectEntity.Patient;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment
{
    public class DiagnosticEquipmentSession
    {
        public int Id { get; set; }
        public virtual Review Review { get; set; }
        public virtual DiagnosticEquipmentSessionName TherapeuticEquipmentSessionName { get; set; }

        public virtual Operator Operator { get; set; }//for short term 
        public virtual Operator helper { get; set; }

        private ICollection<DirectOperatingPartName> _directOperatingPartName;
        public virtual ICollection<DirectOperatingPartName> DirectOperatingPartName
        {

            get { return _directOperatingPartName ?? (_directOperatingPartName = new List<DirectOperatingPartName>()); }

        }

        public string StartDateTime { get; set; }
        private ICollection<EquipmentSessionPauseReport> _equipmentSessionReport;
        public virtual ICollection<EquipmentSessionPauseReport> EquipmentSessionReport
        {

            get { return _equipmentSessionReport ?? (_equipmentSessionReport = new List<EquipmentSessionPauseReport>()); }

        }

        public string EndDateTime { get; set; }

        public string Note { get; set; }

        private ICollection<MeasurementsResault> _measurementsResault { get; set; }
        public virtual ICollection<MeasurementsResault> MeasurementsResault
        {

            get { return _measurementsResault ?? (_measurementsResault = new List<MeasurementsResault>()); }

        }

        private ICollection<SessionMaterial> _sessionMaterial { get; set; }
        public virtual ICollection<SessionMaterial> SessionMaterial
        {

            get { return _sessionMaterial ?? (_sessionMaterial = new List<SessionMaterial>()); }

        }



    }
}
