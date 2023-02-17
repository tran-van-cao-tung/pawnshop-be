using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Core.Models
{
    public class Attribute
    {
        public int AttributeId { get; set; }
        public int PawnableProductID { get; set; }
        public string Description { get; set; }

        public virtual PawnableProduct PawnableProduct { get; set; }
    }
}
