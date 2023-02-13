using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("KYC")]
    public class KYC
    {
        public Guid kycId { get; set; }
        
        //relationship
        public Customer customer { get; set; }
    }
}
