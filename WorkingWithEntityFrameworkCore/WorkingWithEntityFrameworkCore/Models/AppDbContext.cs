using Microsoft.EntityFrameworkCore;
namespace WorkingWithEntityFrameworkCore.Models
{
	public class AppDbContext: DbContext
	{
		//When a derived class is instantiated, it can call the constructor of the base class using the base keyword. 
		//DbContextOptions<AppDbContext> represents the configuration options specific to the AppDbContext class.

		public AppDbContext(DbContextOptions <AppDbContext> options): base(options)
		{

		}
		public DbSet<WebUser> WebUsers { get; set; }
	}
}
