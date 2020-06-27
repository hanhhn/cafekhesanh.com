using Coffee.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Account
{
	public class UserLoginConfigure : EntityTypeConfiguration<UserLogin>
	{
		public override void Configure(EntityTypeBuilder<UserLogin> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(UserLogin));
		}
	}
}