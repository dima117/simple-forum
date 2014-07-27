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

		public LastReplyModel LastReply { get; set; }
	}
}