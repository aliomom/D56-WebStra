using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Financial.AccountTree
{
   public class levelSix
    {
        public virtual levelFive  LevelFive { get; set; }
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AccountId { get { return (" "+ Id + " " + LevelFive.AccountId).ToString(); } set { } }

        public string Name { get; set; }
        public decimal Debit { get; set; }
        public decimal Creadit { get; set; }
        public int FromAccountId { get; set; }

 
    }
}
