using System.ComponentModel.DataAnnotations;

namespace webapi.Data.DataModel
{
    public class StudentTable
    {
        [Key]

        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLasttName { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public bool Status { get; set; }


    }
}
