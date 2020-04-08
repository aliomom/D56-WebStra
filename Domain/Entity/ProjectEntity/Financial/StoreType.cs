using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class StoreType
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSteriled { get; set; }
        public int Wiedth { get; set; }
        public int Lenghth { get; set; }
        public int hight { get; set; }
        public float Tempruture { get; set; }
        [Range(0, 100)]
        public float Humidity { get; set; }
        public float Lighting { get; set; }
        [Range(0, 100)]
        public float PercentageOfChangingAirPer1M { get; set; }


        private ICollection<Stores> _stores;
        public virtual ICollection<Stores> Stores
        {
            get { return _stores ?? (_stores = new List<Stores>()); }
            set { _stores = value; }
        }


    }
}