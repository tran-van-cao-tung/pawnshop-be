using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("WareHouse")]
    public class WareHouse
    {
        [Key]
        public Guid wareHouseId { get; set; }
        public string nameWareHouse { get; set; }
        public string? address { get; set; }
        public byte status { get; set; }

        //relationship
        public ContractAsset ContractAsset { get; set; }
    }
}
