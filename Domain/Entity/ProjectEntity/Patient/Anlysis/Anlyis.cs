using System;
using System.Collections.Generic;
using Domain.Entity.ProjectEntity.Patient;

namespace Domain.Entity.ProjectEntity.Patient.Anlysis
{
    public class Anlyis
    {
        public virtual Review  Review { get; set; }
        public int Id { get; set; }
        public virtual AnlysisType AnlysisType { get; set; }
        private ICollection<AnlyisResult> _anlyisResult;
        public virtual ICollection<AnlyisResult> AnlyisResult
        {
            get { return _anlyisResult ?? (_anlyisResult = new List<AnlyisResult>()); }
            set { _anlyisResult = value; }
        }
        public string Date { get; set; }
        public virtual AnlysisRequest AnlysisRequest { get; set; }




    }
}