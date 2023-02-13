using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("Ledger")]
    public class Ledger
    {
        [Key]
        public Guid legerId { get; set; }
        //tien góc đã nhận
        public double roofMoneyReceived { get; set; }
        //tiền lãi đã nhận
        public double interestReceived { get; set; }
        //tiền cho vay
        public double loan{ get; set; }
        //số dư tài khoản
        public double moneyBalance { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public byte status { get; set; }

        //relationship
        public Guid branchId { get; set; }
        public Branch branch { get; set; }
    }
}
