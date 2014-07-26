using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForum.Web.Models
{
	public interface IMessageModel
	{
		string Text { get; set; }
		Guid AuthorId { get; set; }
		string AuthorDisplayName { get; set; }
		DateTime Created { get; set; }
	}
}
