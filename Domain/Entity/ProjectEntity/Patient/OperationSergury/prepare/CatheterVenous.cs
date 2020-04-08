using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.prepare
{
    public class CatheterVenous
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Venous { get; set; }
        public string Description { get; set; }
        private ICollection<Serum> _serum;
        public virtual ICollection<Serum> Serum
        {

            get { return _serum ?? (_serum = new List<Serum>()); }
            set { _serum = value; }
        }



    }
}