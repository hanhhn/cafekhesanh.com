using Coffee.DataAccess.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class DistrictConfigure : EntityTypeConfiguration<District>
	{
		public override void Configure(EntityTypeBuilder<District> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(District));
		}
	}
}