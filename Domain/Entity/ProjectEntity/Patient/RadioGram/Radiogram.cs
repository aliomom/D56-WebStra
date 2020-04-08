using Domain.Entity.ProjectEntity.Patient;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity
{
    public class Radiogram
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public virtual Review Review { get; set; }
        public RadiogramRefrance RadiogramRefrance { get; set; }
        public byte[] RadioGramImage { get; set; }
        public string RadioGramReport { get; set; }

    }
}