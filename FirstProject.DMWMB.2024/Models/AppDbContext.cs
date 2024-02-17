using System;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DMWMB._2024.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options):
			base(options)
		{
		}
		public DbSet<Movie> movies { get; set; }



	}
}

