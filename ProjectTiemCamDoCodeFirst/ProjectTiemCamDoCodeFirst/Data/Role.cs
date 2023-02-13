using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
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
