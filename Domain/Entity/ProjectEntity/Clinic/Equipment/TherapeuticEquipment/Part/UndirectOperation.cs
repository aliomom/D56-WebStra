﻿using System;
using System.IO;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.TherapeuticEquipment.Part
{
    public class UndirectOperation
    {
        public int Id { get; set; }
        public virtual UndirectOperationName  ChangeablePartsName { get; set; }
        public string date { get; set; }
        
        public string CodeInStock { get; set; }
        public bool IsInUse { get; set; }





    }
}