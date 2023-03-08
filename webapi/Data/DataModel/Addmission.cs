using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.DataModel
{
    public class AddmissionTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddmissionId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SessionId { get; set; }
        public int FeesId { get; set; }
        public string date { get; set; }
    }
  
}
