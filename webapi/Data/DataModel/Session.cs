using System.ComponentModel.DataAnnotations;

namespace webapi.Data.DataModel
{
    public class SessionTable
    {
        [Key]
        public int SessionId { get; set; }
        public int StartDate { get; set; }
        public int SessionEndDate { get; set; }
        public int SessionYear { get; set; }
        public bool Status { get; set; }

    }
}
