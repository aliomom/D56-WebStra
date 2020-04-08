using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.Anlysis
{
    public class AnlyisName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Observed { get; set; }
        public int ForMan { get; set; }
        public int ForWoman { get; set; }
        public int ForKids { get; set; }
        public int ForOldMen { get; set; }
        public decimal Cost { get; set; }
        public AnlysisType AnlysisType { get; set; }
        private ICollection<AnlyisResult> _anlyisResult { get; set; }

        public virtual ICollection<AnlyisResult> AnlyisResult
        {

            get { return _anlyisResult ?? (_anlyisResult = new List<AnlyisResult>()); }

        }
    }
}