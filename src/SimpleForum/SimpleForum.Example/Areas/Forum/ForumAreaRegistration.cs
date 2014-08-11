using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web.Mvc;
using AutoMapper;
using SimpleForum.Domain;
using SimpleForum.Domain.Dto;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models;
using SimpleForum.Web.Models.Forum;
using SimpleForum.Web.Models.Section;
using SimpleForum.Web.Models.Topic;

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
			InitModelMapping();
			
			context.MapRoute(
				"Forum_default",
				"forum/{controller}/{action}/{id}",
				new { controller = "Forum", action = "Index", id = UrlParameter.Optional },
				new[] { "SimpleForum.Web.Controllers" }
			);
		}

		private void InitDatabase()
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<SimpleForumDbContext, SimpleForumMigrationsConfiguration>()); 

			using (var context = new SimpleForumDbContext())
			{
				context.Database.Initialize(false);
			}
		}

		private void InitModelMapping()
		{
			Mapper.CreateMap<SectionDto, ForumIndexSectionModel>();
			Mapper.CreateMap<TopicDto, SectionIndexTopicModel>();
			Mapper.CreateMap<ReplyDto, LastReplyModel>();

			Mapper.CreateMap<Section, SectionIndexModel>();
			Mapper.CreateMap<Topic, TopicIndexModel>();
			Mapper.CreateMap<Reply, TopicIndexReplyModel>();
		}
	}

	public sealed class SimpleForumMigrationsConfiguration : DbMigrationsConfiguration<SimpleForumDbContext>
	{
		public SimpleForumMigrationsConfiguration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(SimpleForumDbContext context)
		{

		}
	}
}
