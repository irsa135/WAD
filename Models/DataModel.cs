using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Falcon.Models
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName="varchar(30)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Required]
        [MaxLength(12)]
        [MinLength(7)]
        public string Password { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        [StringLength(100)]
        public string Message { get; set; }

    }
}
