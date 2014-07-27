using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForum.Domain.Dto
{
	public class SectionDto
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int? TopicCount { get; set; }

		public int? ReplyCount { get; set; }

		public ReplyDto LastReply { get; set; }
	}
}
