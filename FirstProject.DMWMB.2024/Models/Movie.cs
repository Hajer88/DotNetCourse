using System;
namespace FirstProject.DMWMB._2024.Models
{
	public class Movie
	{
		public Movie()
		{
		}
		public Movie(int Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
		}
		public int Id { get; set; }
		
		public string Name { get; set; }
		
	}
}

