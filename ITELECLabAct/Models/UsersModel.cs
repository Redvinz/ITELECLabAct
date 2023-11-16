using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Users")]
    public class UsersModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public int Type { get; set; }
        public string ProfilePicFN { get; set; }
    }
}
