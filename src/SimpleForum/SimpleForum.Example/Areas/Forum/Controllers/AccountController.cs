using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SimpleForum.Domain;
using SimpleForum.Web.Models.Account;

namespace SimpleForum.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

		[HttpGet]
        public ActionResult Login()
        {
	        var model = new LoginModel();
			return View(model);
        }

		[HttpPost]
		public ActionResult Login(LoginModel model)
		{
			if (ModelState.IsValid)
			{
				using (var db = new SimpleForumDbContext())
				{
					var user = db.Users.FirstOrDefault(u => u.Email == model.Email);

					if (user != null)
					{
						FormsAuthentication.RedirectFromLoginPage(user.Email, model.RememberMe);
					}

					model.HesError = true;
				}
			}

			return View(model);
		}

    }
}
