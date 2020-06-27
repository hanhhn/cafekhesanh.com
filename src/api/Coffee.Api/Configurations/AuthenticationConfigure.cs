using Coffee.DataAccess.DbContext;
using Coffee.Libs.DataAccess.Identity.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Api.Configurations
{
	public static class AuthenticationConfigure
	{
		public static void AddCustomIdentity(this IServiceCollection services)
		{
			services.AddIdentity<AppUser, AppRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			services.Configure<IdentityOptions>(options =>
			{
				// Default Lockout settings.
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
				options.Lockout.MaxFailedAccessAttempts = 5;
				options.Lockout.AllowedForNewUsers = true;
			});

			services.Configure<IdentityOptions>(options =>
			{
				// Default Password settings.
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireNonAlphanumeric = true;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 6;
				options.Password.RequiredUniqueChars = 1;
			});

			services.Configure<IdentityOptions>(options =>
			{
				// Default SignIn settings.
				options.SignIn.RequireConfirmedEmail = true;
				options.SignIn.RequireConfirmedPhoneNumber = false;
			});

			services.Configure<IdentityOptions>(options =>
			{
				// Default User settings.
				options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
				options.User.RequireUniqueEmail = true;
			});

			services.Configure<PasswordHasherOptions>(option =>
			{
				option.IterationCount = 12000;
			});

			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.ConfigureApplicationCookie(options =>
			{
				// Default Cookie settings
				options.Cookie.HttpOnly = true;
				options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

				options.LoginPath = "/api/account/ssignin";
				options.AccessDeniedPath = "/api/account/accessdenied";
				options.SlidingExpiration = true;
			});

			services.Configure<DataProtectionTokenProviderOptions>(options =>
			{
				options.TokenLifespan = TimeSpan.FromHours(3);
			});
		}

		public static void AddCustomAuthentication(this IServiceCollection services, IConfiguration configuration)
		{
			JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); // => remove default claims
			services
				.AddAuthentication(options =>
				{
					options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
					options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
					options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				})
				.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
				{
					options.RequireHttpsMetadata = false;
					options.SaveToken = true;
					options.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuer = true,
						ValidIssuer = configuration["Authority"],
						ValidateAudience = true,
						ValidAudience = configuration["Audience"],
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecretKey"])),
						ClockSkew = TimeSpan.Zero
					};

					options.Events = new JwtBearerEvents
					{
						OnAuthenticationFailed = (arg) =>
						{
							// For debugging purposes only!
							var s = $"AuthenticationFailed: {arg.Exception.Message}";
							arg.Response.ContentLength = s.Length;
							arg.Response.Body.Write(Encoding.UTF8.GetBytes(s), 0, s.Length);
							return Task.FromResult(0);
						}
					};

					options.Events = new JwtBearerEvents
					{
						OnMessageReceived = context =>
						{
							var accessToken = context.Request.Query["access_token"];
							var path = context.HttpContext.Request.Path;
							if (!string.IsNullOrEmpty(accessToken))
							{
								context.Token = accessToken;
							}
							return Task.CompletedTask;
						},
					};
				});
		}
	}
}