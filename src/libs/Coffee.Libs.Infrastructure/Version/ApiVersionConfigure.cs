using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Coffee.Libs.Infrastructure
{
	public static class ApiVersionConfigure
	{
		public static void AddCustomApiVersion(this IServiceCollection services)
		{
			services.AddApiVersioning(options =>
			{
				// reporting api versions will return the headers "api-supported-versions" and "api-deprecated-versions"
				options.ReportApiVersions = true;
			});
			services.AddVersionedApiExplorer(options =>
			{
				// add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
				// note: the specified format code will format the version as "'v'major[.minor][-status]"
				options.GroupNameFormat = "'v'VVV";

				// note: this option is only necessary when versioning by url segment. the SubstitutionFormat
				// can also be used to control the format of the API version in route templates
				options.SubstituteApiVersionInUrl = true;
			});

			services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
			services.AddSwaggerGen(options =>
			{
				// integrate xml comments
				// bin\Debug\netcoreapp3.1\Coffee.Gateway.Api.xml
				//options.IncludeXmlComments(XmlCommentsFilePath);
			});
		}

		//static string XmlCommentsFilePath
		//{
		//	get
		//	{
		//		var basePath = PlatformServices.Default.Application.ApplicationBasePath;
		//		var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
		//		return Path.Combine(basePath, fileName);
		//	}
		//}
	}
}
