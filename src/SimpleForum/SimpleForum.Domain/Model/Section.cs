using System;

namespace SimpleForum.Domain.Model
{
	public class Section
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }
	}
}
