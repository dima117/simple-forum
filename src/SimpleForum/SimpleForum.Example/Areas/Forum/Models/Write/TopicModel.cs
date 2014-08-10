using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SimpleForum.Web.Resources;

namespace SimpleForum.Web.Models.Write
{
	public class TopicModel
	{
		public Guid SectionId { get; set; }
		public string SectionTitle { get; set; }

		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[StringLength(140)]
		[Display(ResourceType = typeof(ModelResources), Name = "NewTopicSubject")]
		public string Subject { get; set; }

		[AllowHtml]
		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[Display(ResourceType = typeof(ModelResources), Name = "NewTopicText")]
		public string Text { get; set; }
	}
}