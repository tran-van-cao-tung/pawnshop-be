using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Core.Models
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
    }
}
