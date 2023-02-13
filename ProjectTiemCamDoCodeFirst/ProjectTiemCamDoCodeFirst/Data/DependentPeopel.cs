using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("DependentPeopel")]
    public class DependentPeopel
    {
        [Key]
        public Guid dependentPeopelId { get; set; }
        public string name { get; set; }
        public string customerRelationship { get; set; }
        public double moneyProvided { get; set; }
        public string currentAddress { get; set; }
        public string? addressVerify { get; set; }
        public string phone { get; set; }
        public string? phoneVerify { get; set; }

        //relationship
        public Customer customer { get; set; }
    }
}
