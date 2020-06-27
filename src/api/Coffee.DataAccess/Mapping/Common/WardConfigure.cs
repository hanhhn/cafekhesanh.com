using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class WardConfigure : PostgreEntityTypeConfiguration<Ward>
	{
		public override void Configure(EntityTypeBuilder<Ward> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Ward));
		}
	}
}