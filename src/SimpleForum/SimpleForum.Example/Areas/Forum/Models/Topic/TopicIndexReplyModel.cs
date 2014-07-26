using System;

namespace SimpleForum.Web.Models.Topic
{
	public class TopicIndexReplyModel : IMessageModel
	{
		public Guid Id { get; set; }

		public string Text { get; set; }

		public DateTime Created { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }
	}
}