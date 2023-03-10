using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
	public class RazorPagesMovieContext : DbContext
	{
		public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
		: base(options)
		{
		}
		public DbSet<Movie> Movie { get; set; }
		public DbSet<Customer> Customer { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>().HasData(
			  new { Id = 1, Title = "Fly", ReleaseDate = new DateTime(2023, 2, 3), Genre = "Part 1", Price = 1.99m },
			  new { Id = 2, Title = "Come on", ReleaseDate = new DateTime(2023, 2, 3), Genre = "Part 2", Price = 2.99m }
			  );
            modelBuilder.Entity<Customer>().HasData(
              new { Id = 1, Name = "Châu Du", Birthday = new DateTime(2001, 2, 3), Phone = "0943357474"},
              new { Id = 2, Name = "Nguyễn Hoài", Birthday = new DateTime(2000, 2, 1), Phone = "0943357575" }
              );
        }
	}
}
