﻿using System.Web;
using System.Web.Mvc;

namespace SimpleForum.Example
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}