using System;
using System.Collections.Generic;

namespace SimpleForum.Domain.Model
{
	public class Topic
	{
		public Guid Id { get; set; }
		public string Subject { get; set; }
		public string Text { get; set; }
		public DateTime Created { get; set; }

		// section
		public Guid SectionId { get; set; }
		public Section Section { get; set; }

		// author
		public Guid AuthorId { get; set; }
		public User Author { get; set; }

		public ICollection<Reply> Replies { get; set; }
	}
}
