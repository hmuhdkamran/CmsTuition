using System.ComponentModel.DataAnnotations;

namespace webapi.DataModel
{
    public class SubjectTable
    {
        [Key]

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int TeacherId { get; set; }




    }
}
