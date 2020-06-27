using Coffee.DataAccess.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Orders
{
	public class OrderDetailConfigure : EntityTypeConfiguration<OrderDetail>
	{
		public override void Configure(EntityTypeBuilder<OrderDetail> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(OrderDetail));
		}
	}
}