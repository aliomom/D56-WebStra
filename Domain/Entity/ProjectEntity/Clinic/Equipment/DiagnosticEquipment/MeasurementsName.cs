using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment
{
    public class MeasurementsName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Normal { get; set; }
        public string abserval { get; set; }
        public DiagnosticEquipmentSessionName DiagnosticEquipmentSessionName { get; set; }
        private ICollection<MeasurementsResault> _measurementsResault { get; set; }
        public virtual ICollection<MeasurementsResault> MeasurementsResault
        {

            get { return _measurementsResault ?? (_measurementsResault = new List<MeasurementsResault>()); }

        }
    }
}