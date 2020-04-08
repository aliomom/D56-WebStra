using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.ProjectEntity.Clinic
{
    public class Room
    {
        public virtual Clinic Clinic { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSteriled { get; set; }
        public int Wiedth { get; set; }
        public int Lenghth { get; set; }
        public int hight { get; set; }
        public float Tempruture { get; set; }
        [Range(0,100)]
        public float Humidity { get; set; }
        public float Lighting { get; set; }
        [Range(0, 100)]
        public float PercentageOfChangingAirPer1M { get; set; }
        private ICollection<TreatmentEquipment> _equipment { get; set; }
        public virtual ICollection<TreatmentEquipment> Equipments
        {

            get { return _equipment ?? (_equipment = new List<TreatmentEquipment>()); }

        }

    }
}