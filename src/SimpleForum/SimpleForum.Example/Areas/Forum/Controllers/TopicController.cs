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
				// вынести в базовый контроллер, кэшировать
				var user = db.Users.Single(u => u.Email == User.Identity.Name);

				var topic = db.Set<Topic>()
					.Include("Author")
					.Include("Section")
					.First(s => s.Id == id);
				
				var replies = db.Set<Reply>()
					.Include("Author")
					.Where(r => r.TopicId == id)
					.OrderBy(r => r.Created)
					.ToList();

				var model = Mapper.Map<Topic, TopicIndexModel>(topic);
				model.Replies = replies.Select(Mapper.Map<Reply, TopicIndexReplyModel>).ToList();
				model.UserIsAdministrator = user != null && user.IsAdministrator;
				
				return View(model);
			}
		}
    }
}
