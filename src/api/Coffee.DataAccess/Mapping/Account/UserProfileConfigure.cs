using Coffee.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Account
{
	public class UserProfileConfigure : EntityTypeConfiguration<UserProfile>
	{
		public override void Configure(EntityTypeBuilder<UserProfile> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(UserProfile));
		}
	}
}