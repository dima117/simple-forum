using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleForum.Domain;

namespace SimpleForum.Web.Controllers
{
	[Authorize]
    public class AdministratorController : Controller
    {
		protected override void OnAuthorization(AuthorizationContext filterContext)
		{
			using (var db = new SimpleForumDbContext())
			{
				var user = db.Users.Single(u => u.Email == User.Identity.Name);

				if (!user.IsAdministrator)
				{
					throw new HttpException(401, "access denied");
				}
			}

			base.OnAuthorization(filterContext);
		}

		public ActionResult DeleteTopic(Guid id)
	    {
			using (var db = new SimpleForumDbContext())
			{
				var topic = db.Topics.Include("Replies").FirstOrDefault(t => t.Id == id);

				if (topic != null)
				{
					foreach (var reply in topic.Replies.ToArray())
					{
						db.Replies.Remove(reply);
					}

					db.Topics.Remove(topic);
					db.SaveChanges();
					return RedirectToAction("Index", "Section", new { id = topic.SectionId });
				}

				throw new HttpException(400, "topic is not found");				
			}
	    }
    }
}
