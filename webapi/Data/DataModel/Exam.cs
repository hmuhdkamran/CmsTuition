using System.ComponentModel.DataAnnotations;

namespace webapi.Data.DataModel
{
    public class ExamTable
    {
        [Key]
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public bool Status { get; set; }

    }
}
