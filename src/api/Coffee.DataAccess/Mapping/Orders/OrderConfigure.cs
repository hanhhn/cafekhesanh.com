using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Orders
{
	public class OrderConfigure : PostgreEntityTypeConfiguration<Order>
	{
		public override void Configure(EntityTypeBuilder<Order> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Order));
			builder.HasMany(x => x.OrderDetails).WithOne(y => y.Order);
		}
	}
}