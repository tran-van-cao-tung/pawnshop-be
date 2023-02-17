using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Core.Models
{
    public class Liquidtation
    {
        public int LiquidationID { get; set; }
        public int ContractID { get; set; }
        public int LiquidationMoney { get; set; }
        public int liquidationDate { get; set; }
        public int description { get; set; }


        public virtual Contract? Contract { get; set; }

    }
}
