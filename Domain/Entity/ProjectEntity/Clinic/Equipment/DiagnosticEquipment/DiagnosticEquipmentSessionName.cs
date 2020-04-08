using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment
{
    public class DiagnosticEquipmentSessionName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }


        private ICollection<DiagnosticEquipmentSession> _diagnosticEquipmentSession { get; set; }
        public virtual ICollection<DiagnosticEquipmentSession> DiagnosticEquipmentSession
        {

            get { return _diagnosticEquipmentSession ?? (_diagnosticEquipmentSession = new List<DiagnosticEquipmentSession>()); }
                
        }
        private ICollection<MeasurementsName> _measurementsName { get; set; }
        public virtual ICollection<MeasurementsName> MeasurementsName
        {

            get { return _measurementsName ?? (_measurementsName = new List<MeasurementsName>()); }

        }

        private ICollection<FixedSessionMaterial> _fixedSessionMaterial { get; set; }
        public virtual ICollection<FixedSessionMaterial> FixedSessionMaterial
        {

            get { return _fixedSessionMaterial ?? (_fixedSessionMaterial = new List<FixedSessionMaterial>()); }

        }
    }
}
