using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment.Part
{
    public class DirectOperatingPartName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManufactureCompany { get; set; }
        public string ManufactureCompanyEmail { get; set; }
        public string ManufactureCompanyPhone { get; set; }
        public string ManufactureCompanyAddress { get; set; }
        public string MaintenanceContactPerson { get; set; }
        public string MaintenancePhone { get; set; }
        public byte[] UserGuide { get; set; }
        public string Note { get; set; }
        public int DepreciationPeriod { get; set; }
        public int DepreciationOnOperatingTimes { get; set; }//onec
        private ICollection<DirectOperatingPart> _directOperatingPart;
        public ICollection<DirectOperatingPart> DirectOperatingPart
        {

            get { return _directOperatingPart ?? (_directOperatingPart = new List<DirectOperatingPart>()); }
            set { _directOperatingPart = value; }
        }
        public decimal Cost { get; set; }
    }
}
