using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("Branch")]
    public class Branch
    {
        [Key]
        public Guid branchId { get; set; }
        public string branchName { get; set; }  
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public int? fund { get; set; }
        public DateTime createDate { get; set; }
        public DateTime? updateDate { get; set; }
        public byte status { get; set; }

        //relationship
        public ICollection<User> users { get; set; }
        public ICollection<Ledger> ledger { get; set; }
        public ICollection<Contract> contract { get; set; }
    }
}
