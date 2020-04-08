using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury.Endoscopys
{
    public class Endoscopys
    {
        public virtual AfterSergury AfterSergury { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Report { get; set; }
        private ICollection<EndoscopysImage> _EndoscopysImage;
        public virtual ICollection<EndoscopysImage> EndoscopysImage
        {

            get { return _EndoscopysImage ?? (_EndoscopysImage = new List<EndoscopysImage>()); }
            set { _EndoscopysImage = value; }
        }
        private ICollection<EndoscopysVedio> _endoscopysVedio;
        public virtual ICollection<EndoscopysVedio> EndoscopysVedio
        {

            get { return _endoscopysVedio ?? (_endoscopysVedio = new List<EndoscopysVedio>()); }
            set { _endoscopysVedio = value; }
        }
        public DateTime DateTime { get; set; }

    }
}
