namespace SimpleForum.Web.Models.Account
{
	public class RegistrationModel
	{
		public string DisplayName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string ConfirmPassword { get; set; }
	}
}