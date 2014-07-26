using System.Web.Mvc;
using AutoMapper;
using SimpleForum.Domain;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models.Sections;
using SimpleForum.WebApp.App_Start;

namespace SimpleForum.WebApp.Areas.Forum
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
			ViewEngines.Engines.Add(new SimpleForumViewEngine());

			InitDatabase();
			InitModelMapping();

			context.MapRoute(
				"Forum_default",
				"forum/{controller}/{action}/{id}",
				new { controller = "Sections", action = "Index", id = UrlParameter.Optional },
				new[] { "SimpleForum.WebApp.Areas.Forum.Controllers" }
			);
		}

		private void InitDatabase()
		{
			using (var context = new SimpleForumDbContext())
			{
				context.Database.Initialize(false);
			}
		}

		private void InitModelMapping()
		{
			Mapper.CreateMap<Section, SectionModel>();
		}
	}
}
