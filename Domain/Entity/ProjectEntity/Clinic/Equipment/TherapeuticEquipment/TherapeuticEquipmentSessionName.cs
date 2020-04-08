using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment
{
   public class TherapeuticEquipmentSessionName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        private ICollection<TherapeuticEquipmentSession> _therapeuticEquipmentSession;
        public virtual ICollection<TherapeuticEquipmentSession> TherapeuticEquipmentSession
        {

            get { return _therapeuticEquipmentSession ?? (_therapeuticEquipmentSession = new List<TherapeuticEquipmentSession>()); }

        }
    }
}
