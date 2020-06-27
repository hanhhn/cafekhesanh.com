using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Orders
{
	public class TrackingConfigure : PostgreEntityTypeConfiguration<Tracking>
	{
		public override void Configure(EntityTypeBuilder<Tracking> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Tracking));
		}
	}
}