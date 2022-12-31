using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalExam.Models
{
    public class SearchModelInventory
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Available_Qty { get; set; }
    }
}
