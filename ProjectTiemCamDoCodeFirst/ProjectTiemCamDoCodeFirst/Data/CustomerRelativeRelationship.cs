using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("CustomerRelativeRelationship")]
    public class CustomerRelativeRelationship
    {
        [Key]
        public Guid customerRelativeRelationshipId { get; set; }
        public string relativeName { get; set; }
        public string relativeRelationship { get; set; }
        public double salary { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string? addressVerify { get; set; }
        public string relativePhone { get; set; }
        public string relativePhoneVerify { get; set;}

        //relationship
        public Customer customer { get; set; }
    }
}
