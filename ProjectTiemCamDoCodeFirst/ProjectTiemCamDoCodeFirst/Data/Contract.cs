using ProjectTiemCamDoCodeFirst.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("Contract")]
    public class Contract
    {
        [Key]
        public Guid contractId { get; set; }
        public string contractCode { get; set; }
        public DateTime contractStartDate { get; set; }
        public DateTime? contractEndDate { get; set; }
        public DateTime? actualEndDate { get; set; }
        //khoản vay
        public double loan { get; set; }
        //phí thẩm định
        public double appraisalFee { get; set; }
        //phí bảo hiểm
        public double insuranceFee { get; set; }
        //phí lưu kho
        public double storageFee { get; set; }
        public string? description { get; set; }
        public byte status { get; set; }
        public DateTime? updateDate { get; set; }
        public string? contractVerifyImg { get; set; }

        //relationship
        public Guid customerId { get; set; }
        public Customer customer { get; set; }
        public Guid interestDiaryId { get; set; }
        public InterestDiary InterestDiary { get; set; }
        public Guid packageId { get; set; }
        public Package package { get; set; }
        public Guid branchId { get; set; }
        public Branch branch { get; set; }

        public Liquidation liquidations { get; set; }
        public ICollection<InterestDiary> interestDiaries { get; set; }
        public ContractAsset contractAsset { get; set; }
    }
}
