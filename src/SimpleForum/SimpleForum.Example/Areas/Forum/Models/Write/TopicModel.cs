﻿using System;
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
		public string Subject { get; set; }

		[Required(ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "FieldIsRequired")]
		[AllowHtml]
		public string Text { get; set; }
	}
}