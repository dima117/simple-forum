using System;

namespace SimpleForum.Domain.Model
{
	public class Topic
	{
		public Guid Id { get; set; }

		public string Subject { get; set; }

		public Guid SectionId { get; set; }

		public Section Section { get; set; }

		public DateTime Created { get; set; }

		public Guid AuthorId { get; set; }

		public User Author { get; set; }

		public string Text { get; set; }
	}
}
