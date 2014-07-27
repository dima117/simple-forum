using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForum.Domain.Dto
{
	public class ReplyDto
	{
		public DateTime Created { get; set; }

		public Guid TopicId { get; set; }

		public string TopicSubject { get; set; }

		public Guid AuthorId { get; set; }

		public string AuthorDisplayName { get; set; }
	}
}
