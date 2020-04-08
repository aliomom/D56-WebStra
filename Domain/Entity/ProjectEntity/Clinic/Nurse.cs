using System;

namespace Domain.Entity.ProjectEntity.Clinic
{
    public class Nurse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NameShourtcut
        {
            get
            {
                return
                      "NU"+LastName.Substring(0, 2)
                      + FatherName.Substring(0, 2).ToUpper()
                      + FirstName.Substring(0, 2);
            }
            set { NameShourtcut = value; }
        }

        public string Spicalist { get; set; }
        public string ContractNo { get; set; }
        public byte[] ContractImage { get; set; }
        public byte[] signuture { get; set; }
        public byte[] PerssonalPhoto { get; set; }
        public virtual Clinic Clinic { get; set; }
        public float Salary { get; set; }
        public DateTime WorkStartDate { get; set; }
        public int ContractPeriod { get; set; }

    }
}