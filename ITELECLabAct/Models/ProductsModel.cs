using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Products")]
    public class ProductsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SellerId { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public int ConditionId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Method { get; set; }
        public DateTime DatePosted { get; set; }

        public string PesoPrice => Price.ToString("C");
    }
}
