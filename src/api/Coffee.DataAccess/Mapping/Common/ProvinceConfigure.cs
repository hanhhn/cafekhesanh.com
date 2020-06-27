using Coffee.DataAccess.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class ProvinceConfigure : EntityTypeConfiguration<Province>
	{
		public override void Configure(EntityTypeBuilder<Province> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Province));
		}
	}
}