using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("InterestDiary")]
    public class InterestDiary
    {
        public Guid interestDiaryId {get;set; }
        //tiền cần đóng
        public double moneyToPay { get;set; }
        //tiền đóng phạt
        public double finesToPay { get; set; }
        //tổng cộng
        public double totalToPay { get; set; }
        //số tiền đã đóng
        public double amountPaid { get; set; }
        //ngày cần đóng tiền lãi
        public DateTime dayPay { get; set; }
        //ngày tiếp theo đóng lãi
        public DateTime? dayNextPay { get; set;}
        //ngày khách đóng lãi
        public DateTime? dayLastPay { get; set;}
        public byte status { get; set; }
        public string? desciption { get; set; }
        public string? methodPay { get; set; }
        public string? proof { get; set; }

        //relationship
        public Guid contractId { get; set; }
        public Contract contract { get; set; }
        public ICollection<Contract> contracts { get; set; }
    }
}
