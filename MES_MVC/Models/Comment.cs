using System.ComponentModel.DataAnnotations;

namespace MES_MVC.Models
{
    public class Comment
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [StringLength(500)]
        public string Notes { get; set; }
    }
}