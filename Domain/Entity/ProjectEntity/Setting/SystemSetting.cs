using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Setting
{
   public class SystemSetting
    {
        public int Id { get; set; }
        public string SetteingName { get; set; }
        public int ReviewPeriodInMinute { get; set; }
        
    }
}
