using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; } = Guid.NewGuid();

        public int RoleId { get; set; }

        public int BranchId { get; set; }

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly Dob { get; set; }

        public string Address { get; set; } = null!;

        public int Phone { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int Status { get; set; }


    }

}
