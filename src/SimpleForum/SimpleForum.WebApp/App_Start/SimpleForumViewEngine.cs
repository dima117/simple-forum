using System.Web.Mvc;

namespace SimpleForum.WebApp.App_Start
{
	public class SimpleForumViewEngine : RazorViewEngine
	{
		public SimpleForumViewEngine()
		{
			AreaMasterLocationFormats = new[]
			{
				"~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
				"~/Areas/{2}/Views/%1/{1}/{0}.vbhtml",
				"~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
				"~/Areas/{2}/Views/%1/Shared/{0}.vbhtml",
				"~/Views/%1/Shared/{0}.cshtml",
				"~/Views/%1/Shared/{0}.vbhtml",
				"~/Views/%1/{0}.cshtml",
				"~/Views/%1/{0}.vbhtml"
			};
		}

		protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
		{
			var nameSpace = controllerContext.Controller.GetType().Namespace;
			return base.CreatePartialView(controllerContext, partialPath.Replace("%1", nameSpace));
		}

		protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
		{
			var nameSpace = controllerContext.Controller.GetType().Namespace;
			return base.CreateView(controllerContext, viewPath.Replace("%1", nameSpace), masterPath.Replace("%1", nameSpace));
		}

		protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
		{
			var nameSpace = controllerContext.Controller.GetType().Namespace;
			return base.FileExists(controllerContext, virtualPath.Replace("%1", nameSpace));
		}
	}
}