using System.Web.Mvc;
using SimpleForum.Domain;

namespace SimpleForum.Web
{
	public class ForumAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Forum";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			InitDatabase();

			context.MapRoute(
				"Forum_default",
				"forum/{controller}/{action}/{id}",
				new { controller = "Forum", action = "Index", id = UrlParameter.Optional }
			);
		}

		private void InitDatabase()
		{
			using (var context = new SimpleForumDbContext())
			{
				context.Database.Initialize(false);
			}
		}
	}
}
