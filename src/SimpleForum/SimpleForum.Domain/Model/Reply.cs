using System;

namespace SimpleForum.Domain.Model
{
	public class Reply
	{
		public Guid Id { get; set; }

		public DateTime Created { get; set; }

		public Guid TopicId { get; set; }

		public Topic Topic { get; set; }

		public Guid AuthorId { get; set; }

		public User Author { get; set; }

		public string Text { get; set; }
	}
}
