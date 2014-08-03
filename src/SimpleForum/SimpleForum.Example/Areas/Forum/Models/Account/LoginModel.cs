using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleForum.Web.Models.Account
{
	public class LoginModel
	{
		[Required, DisplayName("Email address")]
		public string Email { get; set; }

		[Required, DisplayName("Password")]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
		public bool HasError { get; set; }
	}
}