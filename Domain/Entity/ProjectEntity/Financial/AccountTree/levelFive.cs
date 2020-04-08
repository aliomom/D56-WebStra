using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree
{
    public class levelFive
    {
        public virtual levelFour LevelFour { get; set; }
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AccountId { get { return (" " + Id + " " + LevelFour.AccountId).ToString(); } set { } }

        public string Name { get; set; }
        public decimal Debit { get; set; }
        public decimal Creadit { get; set; }
        public int FromAccountId { get; set; }

        private ICollection<levelSix> _levelsix { get; set; }
        public virtual ICollection<levelSix> levelThree
        {

            get { return _levelsix ?? (_levelsix = new List<levelSix>()); }

        }

    }
}