using System;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.prepare
{
    public class Serum
    {
        public CatheterVenous  CatheterVenous { get; set; }
        public int Id { get; set; }
        public DateTime DateTime{ get; set; }
        public string Discription  { get; set; }
        public int Size { get; set; }
        public int FlowSpeed { get; set; }
        public int DropPerMl { get; set; }
        public string IsNeedToReplace { get; set; }
        public int NextSerum { get; set; }

    }
}