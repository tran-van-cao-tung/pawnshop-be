using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("Liquidation")]
    public class Liquidation
    {
        [Key]
        public Guid liquidationId { get; set; }
        public double liquidationMoney { get; set; }
        public DateTime liquidationDate { get; set; }
        public string? description { get; set; }

        //relationship
        public Contract contract { get; set; }
        public Guid contractId { get; set; }
    }
}
