using System.ComponentModel.DataAnnotations;

namespace SimpleForum.Web.Models.Write
{
	public class ReplyModel
	{
		public string TopicSubject { get; set; }

		[Required]
		public string Text { get; set; }
	}
}