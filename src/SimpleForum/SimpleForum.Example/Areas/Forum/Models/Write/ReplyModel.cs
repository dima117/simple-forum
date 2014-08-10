using System;
using System.ComponentModel.DataAnnotations;
using SimpleForum.Web.Resources;

namespace SimpleForum.Web.Models.Write
{
	public class ReplyModel
	{
		public Guid SectionId { get; set; }
		public string SectionTitle { get; set; }

		public Guid TopicId { get; set; }
		public string TopicSubject { get; set; }

		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		public string Text { get; set; }
	}
}