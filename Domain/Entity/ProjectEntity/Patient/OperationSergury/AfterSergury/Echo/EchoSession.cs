using Domain.Entity.ProjectEntity.Patient;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Echo
{
    public class EchoSession
    {
        public int Id { get; set; }
        public AfterSergury AfterSergury { get; set; }
        public DateTime Date { get; set; }
        private ICollection<Indication> _idecations;
        public ICollection<Indication> Idecations
        {
            get { return _idecations ?? (_idecations = new List<Indication>()); }
            set { _idecations = value; }
        }


    }
}