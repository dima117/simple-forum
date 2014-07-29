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

		[HttpGet]
		public ActionResult Reply(Guid id)
        {
            return View();
        }
    }
}
