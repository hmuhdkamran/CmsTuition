using System.ComponentModel.DataAnnotations;

namespace webapi.Data.DataModel
{
    public class FeesTable
    {
        [Key]

        public int FeesId { get; set; }
        public int StudentId { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int TotalFee { get; set; }
        public int RecpitNo { get; set; }
        public int RemaningFee { get; set; }
        public bool Paid { get; set; }



    }
}
