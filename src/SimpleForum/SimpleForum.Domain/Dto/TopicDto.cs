using System;

namespace SimpleForum.Domain.Dto
{
	public class TopicDto
	{
		public Guid Id { get; set; }

		public string Subject { get; set; }

		public DateTime Created { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }

		public int ReplyCount { get; set; }

		public ReplyDto LastReply { get; set; }

		public DateTime SortOrder
		{
			get { return LastReply != null ? LastReply.Created : Created; }
		}
	}
}
