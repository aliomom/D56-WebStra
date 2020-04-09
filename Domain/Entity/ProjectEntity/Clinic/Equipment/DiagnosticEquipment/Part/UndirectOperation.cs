using System;
using System.IO;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment.Part
{
    public class UndirectOperation
    {
        public int Id { get; set; }
        public virtual UndirectOperationName UndirectOperationName { get; set; }
        public string date { get; set; }
        
        public string CodeInStock { get; set; }
        public bool IsInUse { get; set; }





    }
}