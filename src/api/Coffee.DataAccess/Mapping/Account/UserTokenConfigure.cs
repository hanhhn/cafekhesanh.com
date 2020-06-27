using Coffee.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Account
{
	public class UserTokenConfigure : EntityTypeConfiguration<UserToken>
	{
		public override void Configure(EntityTypeBuilder<UserToken> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(UserToken));
		}
	}
}