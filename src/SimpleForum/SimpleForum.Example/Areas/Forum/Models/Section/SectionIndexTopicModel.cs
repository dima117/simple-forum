﻿using System;

namespace SimpleForum.Web.Models.Section
{
	public class SectionIndexTopicModel
	{
		public Guid Id { get; set; }

		public string Subject { get; set; }

		public DateTime Created { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }
		
		public int? ReplyCount { get; set; }

		public LastReplyModel LastReply { get; set; }
	}
}