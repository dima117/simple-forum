using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using SimpleForum.Domain;
using SimpleForum.Domain.Dto;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models.Section;

namespace SimpleForum.Web.Controllers
{
	public class SectionController : Controller
	{
		public ActionResult Index(Guid id)
		{
			using (var db = new SimpleForumDbContext())
			{
				var section = db.Set<Section>().First(s => s.Id == id);
				var topics = db.GetTopics(id);

				var model = Mapper.Map<Section, SectionIndexModel>(section);
				model.Topics = topics.Select(Mapper.Map<TopicDto, SectionIndexTopicModel>).ToList();

				return View(model);
			}
		}
	}
}
