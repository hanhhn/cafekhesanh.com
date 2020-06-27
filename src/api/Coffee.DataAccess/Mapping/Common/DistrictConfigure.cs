using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class DistrictConfigure : PostgreEntityTypeConfiguration<District>
	{
		public override void Configure(EntityTypeBuilder<District> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(District));
		}
	}
}