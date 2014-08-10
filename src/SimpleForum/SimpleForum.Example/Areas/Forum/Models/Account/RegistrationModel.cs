using System.ComponentModel.DataAnnotations;
using SimpleForum.Web.Resources;

namespace SimpleForum.Web.Models.Account
{
	public class RegistrationModel
	{
		[Required, Display(ResourceType = typeof(Model), Name = "RegistrationDisplayName")]
		public string DisplayName { get; set; }

		[Required, DataType(DataType.EmailAddress), Display(ResourceType = typeof(Model), Name = "RegistrationEmail")]
		[System.Web.Mvc.Remote("IsEmailAvailable", "Account")]
		public string Email { get; set; }

		[Required, DataType(DataType.Password), Display(ResourceType = typeof(Model), Name = "RegistrationPassword")]
		public string Password { get; set; }

		[Required, DataType(DataType.Password)]
		[Display(ResourceType = typeof(Model), Name = "RegistrationConfirmPassword")]
		[Compare("Password", ErrorMessageResourceType = typeof(Model), ErrorMessageResourceName = "RegistrationPasswordMismatch")]
		public string ConfirmPassword { get; set; }

		public bool HasError { get; set; }
	}
}