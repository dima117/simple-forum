using System.ComponentModel.DataAnnotations;
using SimpleForum.Web.Resources;

namespace SimpleForum.Web.Models.Account
{
	public class LoginModel
	{
		[Required, Display(ResourceType = typeof(Model), Name = "Email")]
		public string Email { get; set; }

		[Required, Display(ResourceType = typeof(Model), Name = "Password")]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
		public bool HasError { get; set; }
	}
}