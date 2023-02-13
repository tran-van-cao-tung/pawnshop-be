using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public Guid customerId { get; set; }
        public string customerName { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public DateTime createDate { get; set; }
        public DateTime? updateDate { get; set; }
        public byte status { get; set; }
        public int point { get; set; }

        //relationship
        public Guid JobId { get; set; }
        public ICollection<Job> job { get; set; }

        public Guid kycId { get; set; }
        public KYC kyc { get; set; }
        public Guid customerRelativeId { get; set; }
        public ICollection<CustomerRelativeRelationship> customerRelativeRelationshipx { get; set; }
        public Guid dependentPeopelId { get; set; }
        public ICollection<DependentPeopel> dependentPeopel { get; set; }

        public ICollection<Contract> contracts { get; set; }

        
    }
}
