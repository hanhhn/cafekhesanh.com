using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class ProvinceConfigure : PostgreEntityTypeConfiguration<Province>
	{
		public override void Configure(EntityTypeBuilder<Province> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Province));
		}
	}
}