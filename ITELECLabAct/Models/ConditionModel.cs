using System.ComponentModel.DataAnnotations.Schema;

namespace ITELECLabAct.Models
{
    [Table("Condition")]
    public class ConditionModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ConditionName { get; set; }   
        public string ConditionDetail { get; set; }
    }
}
