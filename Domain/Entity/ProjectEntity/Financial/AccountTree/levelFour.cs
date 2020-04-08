using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree
{
    public class levelFour
    {
        public virtual levelThree  LevelThree { get; set; }
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AccountId { get { return (" " + Id + " " + LevelThree.AccountId).ToString(); } set { } }

        public string Name { get; set; }
        public decimal Debit { get; set; }
        public decimal Creadit { get; set; }
        public int FromAccountId { get; set; }
        private ICollection<levelFive> _levelFive { get; set; }
        public virtual ICollection<levelFive> levelFive
        {

            get { return _levelFive ?? (_levelFive = new List<levelFive>()); }

        }

    }
}