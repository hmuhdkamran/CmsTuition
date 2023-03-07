using System.ComponentModel.DataAnnotations;

namespace webapi.DataModel
{
    public class ClassTable
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public bool Status { get; set; }
        public int TeacherId { get; set; }

    }
}
