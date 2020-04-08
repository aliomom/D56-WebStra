using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Clinic
{
    public class Doctor
    {
        public int Id { get; set; }
        public int AcountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FatherName { get; set; }
        public string NameShourtcut 
        { get 
            { return
                    "DR."+LastName.Substring(0, 2)
                    +FatherName.Substring(0,2).ToUpper()
                    +FirstName.Substring(0,2);
            }
            set { NameShourtcut = value; }
        }
         
        public string Spicalist { get; set; }
        public string ContractNo { get; set; }
        public byte[] ContractImage { get; set; }
        public byte[] signuture { get; set; }
        public byte[] PersonalPhoto { get; set; }
        public virtual Clinic Clinic { get; set; }
        private ICollection<Appointment> _appointments;
        public ICollection<Appointment> Appointments
        {

            get { return _appointments ?? (_appointments = new List<Appointment>()); }
            set { _appointments = value; }
        }
               


    }
}