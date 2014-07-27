using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using SimpleForum.Domain;
using SimpleForum.Domain.Dto;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models.Forum;

namespace SimpleForum.Web.Controllers
{
    public class ForumController : Controller
    {
        public ActionResult Index()
        {
	        using (var db = new SimpleForumDbContext())
	        {
		        var sections = db.GetSections();
		        var sectionsModel = sections.Select(Mapper.Map<SectionDto, ForumIndexSectionModel>).ToList();

		        var model = new ForumIndexModel
		        {
			        Sections = sectionsModel
		        };

				return View(model);
	        }
        }
    }
}
