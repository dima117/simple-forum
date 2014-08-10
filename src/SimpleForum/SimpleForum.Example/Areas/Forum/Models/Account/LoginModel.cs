using System.ComponentModel.DataAnnotations;
using SimpleForum.Web.Resources;

namespace SimpleForum.Web.Models.Account
{
	public class LoginModel
	{
		[Required, Display(ResourceType = typeof(Model), Name = "LoginEmail")]
		public string Email { get; set; }

		[Required, Display(ResourceType = typeof(Model), Name = "LoginPassword")]
		public string Password { get; set; }

		[Display(ResourceType = typeof(Model), Name = "LoginRememberMe")]
		public bool RememberMe { get; set; }

		public bool HasError { get; set; }
	}
}