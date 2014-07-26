using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleForum.Web.Models.Section
{
	public class SectionIndexModel
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public List<SectionIndexTopicModel> Topics { get; set; } 
	}
}