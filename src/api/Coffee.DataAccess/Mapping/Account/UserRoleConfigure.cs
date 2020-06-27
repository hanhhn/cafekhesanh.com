using Coffee.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Account
{
	public class UserRoleConfigure : EntityTypeConfiguration<UserRole>
	{
		public override void Configure(EntityTypeBuilder<UserRole> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(UserRole));
		}
	}
}