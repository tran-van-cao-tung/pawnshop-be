using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Domain.Entities
{
    [Table("Branch")]
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string? BranchName { get; set; }

        public string? Address { get; set; }

        public int? Phone { get; set; }

        public double? Fund { get; set; }

        public DateTime? CreatedDate { get; set; }
        public int Status { get; set; }


    }

}
