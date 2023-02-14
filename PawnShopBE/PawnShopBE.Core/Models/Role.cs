using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Core.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid roleId { get; set; }
        public string roleName { get; set; }

        public ICollection<User> users { get; set; }
    }
}
