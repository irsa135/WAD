using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Falcon.Models
{
    public class Data
    {
        [Key]
       
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        [StringLength(50, ErrorMessage ="Do not exceed over 50 letters")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        [MaxLength(12)]
        [MinLength(7)]
        public string Password { get; set; }
    }
}
