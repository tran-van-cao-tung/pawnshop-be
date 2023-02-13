using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("PawnableProduct")]
    public class pawnableProduct
    {
        [Key]
        public Guid pawnableProductId { get; set; }
        public string typeOfProduct { get; set; }
        public int commodityCode { get; set; }
        public byte status { get; set; }

        //relation ship
        public ICollection<ContractAsset> contractAssets { get; set; }
    }
}
