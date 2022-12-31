using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalExam.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Available_Qty { get; set; }
    }
}
