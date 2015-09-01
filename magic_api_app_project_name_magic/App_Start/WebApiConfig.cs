using System.Diagnostics.Contracts;
using System.Web.Http;
using Swashbuckle.Application;

namespace magic_api_app_project_name_magic
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			SetupRoutes(config);
			SetupSwagger(config);
		}

		public static void SetupRoutes(HttpConfiguration config)
		{
			config.MapHttpAttributeRoutes();
			config.Routes.MapHttpRoute(
				name: "magic_controller_name_magicApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}

		public static void SetupSwagger(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			config.EnableSwagger(SetupSwaggerConfig).EnableSwaggerUi();
		}

		public static void SetupSwaggerConfig(SwaggerDocsConfig swaggerDocsConfig)
		{
			Contract.Requires(swaggerDocsConfig != null);

			swaggerDocsConfig.SingleApiVersion("v1", "magic_api_app_title_magic");
		}
	}
}
