using System;

namespace SimpleForum.Web.Models
{
	public class LastReplyModel
	{
		public DateTime Created { get; set; }

		public Guid TopicId { get; set; }

		public string TopicSubject { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }
	}
}