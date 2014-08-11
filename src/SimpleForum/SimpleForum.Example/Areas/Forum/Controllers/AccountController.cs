using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Security;
using SimpleForum.Domain;
using SimpleForum.Domain.Model;
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
					var hash = GetPasswordHash(model.Email, model.Password);
					var user = db.Users
						.FirstOrDefault(u => u.Email == model.Email && u.PasswordHash == hash);

					if (user != null)
					{
						FormsAuthentication.SetAuthCookie(user.Email, false);

						var url = FormsAuthentication.GetRedirectUrl(user.Email, model.RememberMe);

						if (url != FormsAuthentication.DefaultUrl)
						{
							return Redirect(url);
						}

						return RedirectToAction("Index", "Forum");
					}

					model.HasError = true;
				}
			}

			return View(model);
		}

		[HttpGet]
		public ActionResult Registration()
		{
			var model = new RegistrationModel();
			return View(model);
		}

		[HttpPost]
		public ActionResult Registration(RegistrationModel model)
		{
			if (ModelState.IsValid)
			{
				using (var db = new SimpleForumDbContext())
				{
					var user = db.Users.FirstOrDefault(u => u.Email == model.Email);

					if (user == null)
					{
						var hash = GetPasswordHash(model.Email, model.Password);

						user = new User
						{
							Id = Guid.NewGuid(),
							DisplayName = model.DisplayName,
							Email = model.Email,
							PasswordHash = hash
						};

						db.Users.Add(user);
						db.SaveChanges();

						FormsAuthentication.SetAuthCookie(user.Email, false);
						return RedirectToAction("Index", "Forum");
					}

					model.HasError = true;
				}
			}

			return View(model);

		}

		public ActionResult IsEmailAvailable(string email)
		{
			using (var db = new SimpleForumDbContext())
			{
				var isAvailable = !db.Users.Any(u => u.Email == email);
				return Json(isAvailable, JsonRequestBehavior.AllowGet);
			}
		}

		static string GetPasswordHash(string email, string password)
		{
			string str = email.ToLower() + ":" + password;

			using (var crypt = new SHA256Managed())
			{
				byte[] strBytes = Encoding.UTF8.GetBytes(str);
				byte[] hashBytes = crypt.ComputeHash(strBytes);

				return Convert.ToBase64String(hashBytes);
			}
		}

		public ActionResult UserInfo()
	    {
		    UserInfoModel model = null;

		    if (User.Identity.IsAuthenticated)
		    {
			    var email = User.Identity.Name;

			    string key = "5669B56F-48B6-4AED-8564-F549A3BC36FA-" + email;

			    model = HttpContext.Cache[key] as UserInfoModel;
			    
				if (model == null)
			    {
				    using (var db = new SimpleForumDbContext())
				    {
					    var user = db.Users
						    .First(u => u.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase));

						model = new UserInfoModel{DisplayName = user.DisplayName};
					    HttpContext.Cache.Add(key, model, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(5),
						    CacheItemPriority.Default, null);
				    }
			    }
		    }

			return PartialView(model);
	    }

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Forum");
		}
	}
}
