using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using SimpleForum.Domain;
using SimpleForum.Domain.Model;
using SimpleForum.Web.Models.Sections;

namespace SimpleForum.Web.Controllers
{
    public class SectionsController : Controller
    {
        public ActionResult Index()
        {
	        using (var db = new SimpleForumDbContext())
	        {
		        var sections = db.Set<Section>().ToList();
		        var sectionsModel = sections.Select(Mapper.Map<Section, SectionModel>).ToList();

		        var model = new SectionsIndexModel
		        {
			        Sections = sectionsModel
		        };

				return View(model);
	        }
        }

    }
}
