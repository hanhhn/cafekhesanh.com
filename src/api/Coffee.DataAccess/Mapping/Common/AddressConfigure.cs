using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class AddressConfigure : PostgreEntityTypeConfiguration<Address>
	{
		public override void Configure(EntityTypeBuilder<Address> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Address));
		}
	}
}