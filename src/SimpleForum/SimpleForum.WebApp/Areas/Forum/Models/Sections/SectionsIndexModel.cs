using System;
using System.Collections.Generic;

namespace SimpleForum.WebApp.Areas.Forum.Models.Sections
{
	public class SectionsIndexModel
	{
		public List<SectionModel> Sections { get; set; }
	}

	public class SectionModel
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }
	}
}