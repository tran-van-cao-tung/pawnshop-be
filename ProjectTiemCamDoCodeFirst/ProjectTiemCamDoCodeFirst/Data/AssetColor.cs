using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("AssetColor")]
    public class AssetColor
    {
        [Key]
        public Guid assetColorId { get; set; }
        public string nameColor { get; set; }

        //relation ship
        public ICollection<ContractAsset> contractAssets { get; set; }
    }
}
