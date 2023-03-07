using System.ComponentModel.DataAnnotations;

namespace webapi.DataModel
{
    public class AttandanceTable
    {
        [Key]

        public int AttendanceId { get; set; }
        public int StudentId {get; set; }
        public string Day { get; set; }
        public string Date { get;set; }
        public string Month { get; set; }
        public bool Status { get; set; }



    }
}
