using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Setting
{
    class FinanncialSetting
    {

        public int Id { get; set; }
        public decimal ReviewPrice { get; set; }
        public decimal PriceOfExtraMinuteInReview { get; set; }
        public string MainCurrency { get; set; }
        public string SubCurrency { get; set; }
        public decimal ConversionFactor { get; set; }
    }
}
