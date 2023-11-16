using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Categories")]
    public class CategoriesModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
