using Coffee.Libs.DataAccess.Identity.Entities;
using Coffee.Libs.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Coffee.Libs.DataAccess.Identity.DbContext
{
	public class IdentityApplicationDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>, IDbContext
	{
		public static readonly ILoggerFactory DbLoggerFactory = LoggerFactory.Create(builder => { builder.AddDebug(); });

		public IdentityApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseLoggerFactory(DbLoggerFactory).EnableSensitiveDataLogging();
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			TablesBuilder.Build(builder);
		}
	}
}