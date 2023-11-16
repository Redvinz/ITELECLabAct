using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Saves")]
    public class SavesModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsersId { get; set; }
        public string ProductsId { get; set; }
    }
}
