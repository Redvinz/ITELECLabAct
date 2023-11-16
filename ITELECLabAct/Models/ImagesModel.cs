using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Images")]
    public class ImagesModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductsId { get; set; }
        public string Filename { get; set; }
    }
}
