using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coffee.Libs.DataAccess.Mapping;
using Coffee.Libs.DataAccess.Identity.Entities;

namespace Coffee.Libs.DataAccess.Identity.Mapping
{
	public class AppRoleConfigure : EntityTypeConfiguration<AppRole>
	{
		public override void Configure(EntityTypeBuilder<AppRole> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(AppRole));
		}
	}
}
