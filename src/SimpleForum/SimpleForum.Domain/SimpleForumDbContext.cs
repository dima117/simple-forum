using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SimpleForum.Domain.Model;

namespace SimpleForum.Domain
{
	public class SimpleForumDbContext : DbContext
	{
		public SimpleForumDbContext()
			: base("SimpleForum.MainDB")
		{
		}

		      protected override void OnModelCreating( DbModelBuilder modelBuilder )
      {

         modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


      }

		public DbSet<User> User { get; set; }
		public DbSet<Reply> Reply { get; set; }
		public DbSet<Topic> Topic { get; set; }
		public DbSet<Section> Section { get; set; } 
	}
}
