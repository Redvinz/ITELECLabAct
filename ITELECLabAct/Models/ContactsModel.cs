using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Contacts")]
    public class ContactsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsersId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
