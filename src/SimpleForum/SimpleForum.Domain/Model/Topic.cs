using System;

namespace SimpleForum.Domain.Model
{
	public class Topic
	{
		public Guid Id { get; set; }

		public string Subject { get; set; }

		public Guid SectionId { get; set; }

		public Section Section { get; set; }
	}
}
