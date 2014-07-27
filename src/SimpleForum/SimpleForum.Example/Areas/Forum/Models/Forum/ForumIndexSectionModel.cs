using System;

namespace SimpleForum.Web.Models.Forum
{
	public class ForumIndexSectionModel
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int? TopicCount { get; set; }

		public int? ReplyCount { get; set; }

		public ForumIndexLastReplyModel LastReply { get; set; }
	}

	public class ForumIndexLastReplyModel
	{
		public DateTime Created { get; set; }

		public Guid TopicId { get; set; }

		public string TopicSubject { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }
	}
}