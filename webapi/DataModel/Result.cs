using System.ComponentModel.DataAnnotations;

namespace webapi.DataModel
{
    public class ResultTable
    {
        [Key]

        public int ResultId { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int Marks { get;set; }
        public int SubjectId { get;set; }

    }
}
