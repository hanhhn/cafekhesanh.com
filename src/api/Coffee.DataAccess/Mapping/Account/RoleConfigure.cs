using Coffee.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Account
{
	public class RoleConfigure : EntityTypeConfiguration<Role>
	{
		public override void Configure(EntityTypeBuilder<Role> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Role));
		}
	}
}