using System.Data.Entity;
using SimpleForum.Domain.Model;

namespace SimpleForum.Domain
{
	public class SimpleForumDbContext : DbContext
	{
		public SimpleForumDbContext()
			: base("SimpleForum.MainDB")
		{
		}

		public DbSet<User> User { get; set; }
		public DbSet<Reply> Reply { get; set; }
		public DbSet<Topic> Topic { get; set; }
		public DbSet<Section> Section { get; set; } 
	}
}
