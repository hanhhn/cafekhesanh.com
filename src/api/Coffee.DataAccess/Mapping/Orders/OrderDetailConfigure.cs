using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Orders
{
	public class OrderDetailConfigure : PostgreEntityTypeConfiguration<OrderDetail>
	{
		public override void Configure(EntityTypeBuilder<OrderDetail> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(OrderDetail));
		}
	}
}