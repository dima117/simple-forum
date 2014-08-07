1. Добавить строку подключения

	<connectionStrings>
		<add name="SimpleForum.MainDB" connectionString="Data Source=.;Initial Catalog=simpleforum;Integrated Security=SSPI;" providerName="System.Data.SqlClient" />
	</connectionStrings>

2. Добавить настройки аутентификации в раздел system.web
	
	<authentication mode="Forms">
		<forms loginUrl="~/forum/Account/Login" timeout="2880" />
	</authentication> 

3. общий шаблон страницы для всего приложения
	3.1 Положить в корень приложения файл _ViewStart.cshtml и указать путь к общему шаблону
	
	@{
		Layout = "~/Views/Shared/_LayoutMaster.cshtml";
	} 

	3.2 в Web.config в раздел configSections добавить

	<sectionGroup name="system.web.webPages.razor" type="System.Web.WebPages.Razor.Configuration.RazorWebSectionGroup, System.Web.WebPages.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35">
		<section name="host" type="System.Web.WebPages.Razor.Configuration.HostSection, System.Web.WebPages.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" requirePermission="false" />
		<section name="pages" type="System.Web.WebPages.Razor.Configuration.RazorPagesSection, System.Web.WebPages.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" requirePermission="false" />
	</sectionGroup>

	3.3 в Web.config добавить раздел

	<system.web.webPages.razor>
		<host factoryType="System.Web.Mvc.MvcWebRazorHostFactory, System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
		<pages pageBaseType="System.Web.Mvc.WebViewPage">
			<namespaces>
				<add namespace="System.Web.Mvc" />
				<add namespace="System.Web.Mvc.Ajax" />
				<add namespace="System.Web.Mvc.Html" />
				<add namespace="System.Web.Routing" />
			</namespaces>
		</pages>
	</system.web.webPages.razor>

4. Клиентская валидация
	- инсталлировать пакеты
		Install-Package jQuery 
		Install-Package jQuery.Validation
		Install-Package Microsoft.jQuery.Unobtrusive.Validation
	- подключить скрипты из пакетов в шаблон страницы

5. Стили
	- инсталлировать пакеты
		Install-Package bootstrap 
		Install-Package FontAwesome 
	- подключить стили из пакетов в шаблон страницы