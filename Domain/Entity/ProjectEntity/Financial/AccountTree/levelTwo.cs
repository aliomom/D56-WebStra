using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree
{
    public class levelTwo
    {
        public virtual leavelOne LeavelOne { get; set; }
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AccountId { get { return (" " + Id +" "+ LeavelOne.AccountId).ToString(); } set { } }
       
        public string Name { get; set; }
        public decimal Debit { get; set; }
        public decimal Creadit { get; set; }
        public int FromAccountId { get; set; } 

        private ICollection<levelThree> _levelThree { get; set; }
        public virtual ICollection<levelThree> levelThree
        {

            get { return _levelThree ?? (_levelThree = new List<levelThree>()); }

        }


    }
}