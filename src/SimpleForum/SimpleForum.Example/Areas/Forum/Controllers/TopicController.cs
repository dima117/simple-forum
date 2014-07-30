using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using SimpleForum.Domain;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models.Topic;

namespace SimpleForum.Web.Controllers
{
    public class TopicController : Controller
    {
		public ActionResult Index(Guid id)
		{
			using (var db = new SimpleForumDbContext())
			{
				var topic = db.Set<Topic>().Include("Author").First(s => s.Id == id);
				var replies = db.Set<Reply>()
					.Where(r => r.TopicId == id)
					.OrderBy(r => r.Created)
					.ToList();

				var model = Mapper.Map<Topic, TopicIndexModel>(topic);
				model.Replies = replies.Select(Mapper.Map<Reply, TopicIndexReplyModel>).ToList();
				
				return View(model);
			}
		}
    }
}
