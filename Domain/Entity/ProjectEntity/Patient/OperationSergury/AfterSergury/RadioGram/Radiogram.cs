using Domain.Entity.ProjectEntity.Patient;
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.RadioGram
{
    public class Radiogram
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual AfterSergury  AfterSergury   { get; set; }
        public  virtual RadioGramType RadioGramType { get; set; }
        public string RadioGramName { get; set; }
        public byte[] RadioGramImage { get; set; }
        public string RadioGramReport { get; set; }

    }
}