using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dto
{
   public class ChangeUserPassDto
    {
        public string oldPass { set; get; }
        public string NewPass { set; get; }
        public string ConfirmPass { set; get; }
    }
}
