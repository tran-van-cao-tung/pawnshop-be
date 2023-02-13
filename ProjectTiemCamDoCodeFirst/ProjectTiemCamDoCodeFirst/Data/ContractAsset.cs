using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("ContractAsset")]
    public class ContractAsset
    {
        public Guid contractAssetId { get; set; }
        public string nameAsset { get; set; }
        public string? description { get; set; }
        public string image { get; set; }
        public byte status { get; set; }
        public int serialCode { get; set; }

        //relationship
        public Guid contractId { get; set; }
        public ICollection<Contract> contract { get; set; }
        public Guid wareHouseId { get; set; }
        public WareHouse wareHouse { get; set; }
        public Guid pawnableProductId { get; set; }
        public pawnableProduct pawnableProduct { get; set; }
        public Guid assetColorId { get; set; }
        public AssetColor assetColor { get; set; }
    }
}
