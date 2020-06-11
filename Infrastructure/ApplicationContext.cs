using System.Data.Entity;
using Domaine.Entities;

namespace Infrastructure
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext() : base("name=DBName") {}
		public DbSet<CivilState> CivilStates { get; set; }
		public DbSet<Profile> Profiles { get; set; }
	}
}