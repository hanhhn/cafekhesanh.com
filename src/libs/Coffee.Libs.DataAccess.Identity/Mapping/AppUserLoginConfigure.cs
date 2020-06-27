using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coffee.Libs.DataAccess.Mapping;
using Coffee.Libs.DataAccess.Identity.Entities;

namespace Coffee.Libs.DataAccess.Identity.Mapping
{
	public class AppUserLoginConfigure : EntityTypeConfiguration<AppUserLogin>
	{
		public override void Configure(EntityTypeBuilder<AppUserLogin> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(AppUserLogin));
		}
	}
}
