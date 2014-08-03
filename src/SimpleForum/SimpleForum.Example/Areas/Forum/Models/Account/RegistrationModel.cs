using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SimpleForum.Web.Models.Account
{
	public class RegistrationModel
	{
		[Required]
		public string DisplayName { get; set; }

		[Required, DataType(DataType.EmailAddress)]
		[Remote("IsEmailAvailable", "Account")]
		public string Email { get; set; }

		[Required, DataType(DataType.Password)]
		public string Password { get; set; }

		[Required, DataType(DataType.Password), System.ComponentModel.DataAnnotations.Compare("Password")]
		public string ConfirmPassword { get; set; }

		public bool HasError { get; set; }
	}
}