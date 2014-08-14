using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace SimpleForum.Web.Helpers
{
	public static class ViewHelper
	{
		private const string PATTERN = @"(https?|ftp|file)\://[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\*\-\._~%]*)*";
		private const string REPLACEMENT = @"<a href=""$0"" rel=""nofollow"" target=""_blank"">$0</a>";
		private readonly static Regex regex = new Regex(PATTERN, RegexOptions.IgnoreCase);

		public static IHtmlString PrepareText(this HtmlHelper helper, string text)
		{
			var str = HttpUtility.HtmlEncode(text ?? string.Empty);
			var html = regex.Replace(str, REPLACEMENT).Replace("\r\n", "<br />");

			return new MvcHtmlString(html);
		}
	}
}