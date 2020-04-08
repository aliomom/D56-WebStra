using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree
{
    public class levelThree
    {
        public virtual levelTwo  LevelTwo { get; set; }
        public int Id { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AccountId { get { return (" " + Id + " " + LevelTwo.AccountId).ToString(); } set { } }

        public string Name { get; set; }
        public decimal Debit { get; set; }
        public decimal Creadit { get; set; }
        public int FromAccountId { get; set; }
        private ICollection<levelFour> _levelFour { get; set; }
        public virtual ICollection<levelFour> levelFour
        {

            get { return _levelFour ?? (_levelFour = new List<levelFour>()); }

        }

    }
}