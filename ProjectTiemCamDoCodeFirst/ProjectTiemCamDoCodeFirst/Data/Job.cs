using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTiemCamDoCodeFirst.Data
{
    [Table("Job")]
    public class Job
    {
        [Key]
        public Guid jobId { get; set; }
        public string laborContract { get; set; }
        public string permanentResidence { get; set; }
        public string workLocation { get; set; }
        public double salary { get; set; }
        public byte jobStatus { get; set; }

        //relation ship
        public  Customer customer { get; set; }
    }
}
