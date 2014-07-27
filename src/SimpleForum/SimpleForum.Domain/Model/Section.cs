using System;
using System.Collections.Generic;

namespace SimpleForum.Domain.Model
{
	public class Section
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public ICollection<Topic> Topics { get; set; }
	}
}
