using System;
using System.Web.Mvc;

namespace SimpleForum.Web.Controllers
{
	[Authorize]
    public class WriteController : Controller
    {
		[HttpGet]
        public ActionResult Topic(Guid id)
        {
            return View();
        }

		[HttpGet]
		public ActionResult Reply(Guid id)
        {
            return View();
        }
    }
}
