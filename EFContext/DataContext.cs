using Curriculum_Vitae_Project.Model.Items;
using Microsoft.EntityFrameworkCore;

namespace Curriculum_Vitae_Project.EFContext
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Company> Companies => Set<Company>();

		public DbSet<CurriculumVitae> CurriculumVitaes => Set<CurriculumVitae>();
		public DbSet<Person> Authors => Set<Person>();
		public DbSet<Project> Projects => Set<Project>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			_ = modelBuilder.Entity<Company>().HasKey(c => c.Id);

			_ = modelBuilder.Entity<CurriculumVitae>().HasKey(c => c.Id);

			_ = modelBuilder.Entity<Person>().HasKey(c => c.Id);

			_ = modelBuilder.Entity<Project>().HasKey(c => c.Id);

		}
	}
}
