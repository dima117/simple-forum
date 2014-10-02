using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleForum.Domain.Model
{
	public class User
	{
		public Guid Id { get; set; }

		public string Email { get; set; }

		public string DisplayName { get; set; }

		[StringLength(44)]
		public string PasswordHash { get; set; }

		[NotMapped]
		public bool IsAdministrator
		{
			get
			{
				return string.Equals(Email, "dandriyanov@thinking-home.ru", StringComparison.CurrentCultureIgnoreCase);
			}
		}
	}
}
