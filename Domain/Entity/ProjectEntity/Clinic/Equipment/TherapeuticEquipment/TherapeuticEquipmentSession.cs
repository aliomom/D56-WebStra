using Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment.Part;
using Domain.Entity.ProjectEntity.Financial;
using Domain.Entity.ProjectEntity.Patient.Treatment;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment
{
    public class TherapeuticEquipmentSession
    {
        public int Id { get; set; }

        public virtual TherapeuticEquipmentSessionName TherapeuticEquipmentSessionName { get; set; }
        public virtual Treatments Treatment { get; set; }

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

        private ICollection<DevicesSetting> _devicesSetting { get; set; }
        public virtual ICollection<DevicesSetting> DevicesSetting
        {

            get { return _devicesSetting ?? (_devicesSetting = new List<DevicesSetting>()); }

        }




       





    }
}
