using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Billing
{
	public class BillDetailConfigure : PostgreEntityTypeConfiguration<BillDetail>
	{
		public override void Configure(EntityTypeBuilder<BillDetail> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(BillDetail));
		}
	}
}