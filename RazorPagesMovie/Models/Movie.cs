using Microsoft.EntityFrameworkCore.Update.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
	public class Movie
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required]

		public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
		public string Title { get; set; } = string.Empty;

		[DataType(DataType.Date)]
		[Required]
		[Display(Name = "Release Date")]
		public DateTime ReleaseDate { get; set; }

		[MaxLength(50)]
		[Required]
		public string Genre { get; set; } = string.Empty;

		[Required]
        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
		public decimal Price { get; set; }

	}
}