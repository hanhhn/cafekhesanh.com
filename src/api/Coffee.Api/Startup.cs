using Coffee.Api.Configurations;
using Coffee.DataAccess.DbContext;
using Coffee.Libs.DataAccess.Identity.Entities;
using Coffee.Libs.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Coffee.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<IIdentityContext, IdentityContext>();

			services.AddHttpContextAccessor();

			services.AddCustomDbContext(Configuration);

			services.AddCustomAutoMapper();

			services.AddCustomServices(Configuration);

			services.AddCustomIdentity();

			services.AddCustomAuthentication(Configuration);

			services.AddCors();

			services.AddCustomApiVersion();

			services.AddControllers(options =>
			{
				options.Filters.Add(typeof(HttpGlobalExceptionFilter));
				options.Filters.Add(typeof(ModelStateValidationFilter));
			}).AddCustomValidation(typeof(Service.DependencyInjection))
			.AddNewtonsoftJson();

			// Customise default API behaviour
			services.Configure<ApiBehaviorOptions>(options =>
			{
				options.SuppressModelStateInvalidFilter = true;
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(
			IApplicationBuilder app,
			IWebHostEnvironment env,
			IApiVersionDescriptionProvider provider,
			ApplicationDbContext dbContext,
			RoleManager<AppRole> roleManager,
			UserManager<AppUser> userManager)
		{
			dbContext.Database.EnsureCreated();
			SeedDefaultData(roleManager, userManager);


			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseCors(config =>
			{
				config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
			});

			app.UseRouting();

			app.UseAuthorization();

			app.UseSwagger();

			app.UseCors(builder => builder
				.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader());

			app.UseSwaggerUI(options =>
			{
				//build a swagger endpoint for each discovered API version
				foreach (var description in provider.ApiVersionDescriptions)
				{
					options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName);
				}
			});

			app.UseMiddleware<JwtToIdentityMiddleware>();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
				endpoints.MapControllers();
			});
		}

		private void SeedDefaultData(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
		{
			var creator = new DefaultUserAndRoleCreator(roleManager, userManager);
			creator.Create();
		}
	}
}