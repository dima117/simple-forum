using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleForum.Web.Models.Topic
{
	public class TopicIndexModel : IMessageModel
	{
		public Guid Id { get; set; }
		
		public string Subject { get; set; }

		public DateTime Created { get; set; }

		public string Text { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }

		public List<TopicIndexReplyModel> Replies { get; set; } 
	}
}