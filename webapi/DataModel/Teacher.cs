using System.ComponentModel.DataAnnotations;

namespace webapi.DataModel
{
    public class TeacherTable
    {
        [Key]

        public int TeacherId { get; set; }
        public string TeacherName {get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
