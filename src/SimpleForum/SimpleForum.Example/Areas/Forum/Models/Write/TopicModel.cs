using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleForum.Web.Models.Write
{
	public class TopicModel
	{
		public Guid SectionId { get; set; }
		public string SectionTitle { get; set; }
		
		[Required]
		[StringLength(140)]
		public string Subject { get; set; }

		[Required]
		public string Text { get; set; }
	}
}