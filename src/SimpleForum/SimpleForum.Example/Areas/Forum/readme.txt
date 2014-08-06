1. Добавить строку подключения

	<connectionStrings>
		<add name="SimpleForum.MainDB" connectionString="Data Source=.;Initial Catalog=simpleforum;Integrated Security=SSPI;" providerName="System.Data.SqlClient" />
	</connectionStrings>

2. Добавить настройки аутентификации в раздел system.web
	
	<authentication mode="Forms">
		<forms loginUrl="~/forum/Account/Login" timeout="2880" />
	</authentication> 