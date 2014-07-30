using System;
using System.Linq;
using System.Web.Mvc;
using SimpleForum.Domain;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models.Write;

namespace SimpleForum.Web.Controllers
{
	[Authorize]
	public class WriteController : Controller
	{
		[HttpGet]
		public ActionResult Topic(Guid id)
		{
			using (var db = new SimpleForumDbContext())
			{
				var section = db.Set<Section>().Single(s => s.Id == id);

				var model = new TopicModel
				{
					SectionTitle = section.Title
				};

				return View(model);
			}
		}

		[HttpPost]
		public ActionResult Topic(Guid id, TopicModel model)
		{
			using (var db = new SimpleForumDbContext())
			{
				var user = db.Users.Single(u => u.Email == User.Identity.Name);
				var section = db.Set<Section>().Single(s => s.Id == id);

				if (!ModelState.IsValid)
				{
					model.SectionTitle = section.Title;
					return View(model);
				}

				Guid topicId = Guid.NewGuid();

				var topic = new Topic
				{
					Id = topicId,
					Subject = model.Subject,
					Text = model.Text,
					Created = DateTime.Now,

					AuthorId = user.Id,
					SectionId = section.Id
				};

				db.Set<Topic>().Add(topic);
				db.SaveChanges();

				return RedirectToAction("Index", "Topic", new { id = topicId });
			}
		}

		[HttpGet]
		public ActionResult Reply(Guid id)
		{



			return View();
		}
	}
}
