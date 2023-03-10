using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RazorPagesMovie.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthday { get; set; }

        [Phone]
        [Required]
        public string Phone { get; set; } = string.Empty;
    }
}
