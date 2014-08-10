using System.ComponentModel.DataAnnotations;
using SimpleForum.Web.Resources;

namespace SimpleForum.Web.Models.Account
{
	public class RegistrationModel
	{
		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[Display(ResourceType = typeof(ModelResources), Name = "RegistrationDisplayName")]
		public string DisplayName { get; set; }

		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[DataType(DataType.EmailAddress), Display(ResourceType = typeof(ModelResources), Name = "RegistrationEmail")]
		[System.Web.Mvc.Remote("IsEmailAvailable", "Account")]
		public string Email { get; set; }

		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[DataType(DataType.Password), Display(ResourceType = typeof(ModelResources), Name = "RegistrationPassword")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[Display(ResourceType = typeof(ModelResources), Name = "RegistrationConfirmPassword")]
		[Compare("Password", ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "RegistrationPasswordMismatch")]
		public string ConfirmPassword { get; set; }

		public bool HasError { get; set; }
	}
}