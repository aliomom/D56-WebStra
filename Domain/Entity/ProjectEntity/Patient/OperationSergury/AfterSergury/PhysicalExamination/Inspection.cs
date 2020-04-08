using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.PhysicalExamination
    public class Inspection//المعاينة والملاحظة
    {//In medical terms, "inspection" means to look at the person or body part. It is the first step in a physical exam
        public PhysicalExaminations  PhysicalExamination { get; set; }
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        private ICollection<PathologicalSigns> _pathologicalSigns;
/*Total number of teeth
Non-removable teeth in contact
Oral prosthesis
Mucosal inflammation score
Plaque score for teeth and dentures
Hearing aid
Cranial nerves IX-X, oropharynx asymmetry
Cranial nerves III, IV, VI:
Vertical ocular movement asymmetry
Horizontal ocular movement asymmetry
Wavy ocular tracking asymmetry
Nystagmus
Convergence
Heart murmurs .... etc from https://www.blsa.nih.gov/sites/default/files/d7/Operations_Manual_Physical_Exam.pdf
*/
        public virtual ICollection<PathologicalSigns> PathologicalSigns
        {
            get { return _pathologicalSigns ?? (_pathologicalSigns = new List<PathologicalSigns>()); }
            set { _pathologicalSigns = value; }
        }

        public string Note { get; set; }

    }
}