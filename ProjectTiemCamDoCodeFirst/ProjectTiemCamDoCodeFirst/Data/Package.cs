using ProjectTiemCamDoCodeFirst.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Model
{
    [Table("Package")]
    public class Package
    {
        [Key]
        public Guid packageID { get; set; }
        public string packageName { get; set; }
        public int packageInterest { get; set; }
        public double paymentPeriod { get; set; }
        public int days { get; set; }
        public int limitation { get; set; }
        public int punishDay1 { get; set; }
        public int punishDay2 { get; set; }
        public int liquidationDay { get; set; }

        //relationship
        public ICollection<Contract> contracts { get; set; }
    }
}
