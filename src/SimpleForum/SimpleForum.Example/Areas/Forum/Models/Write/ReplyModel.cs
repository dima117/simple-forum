using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleForum.Web.Models.Write
{
	public class ReplyModel
	{
		public Guid SectionId { get; set; }
		public string SectionTitle { get; set; }

		public Guid TopicId { get; set; }
		public string TopicSubject { get; set; }

		[Required]
		public string Text { get; set; }
	}
}