﻿using Coffee.DataAccess.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Account
{
	public class UserClaimConfigure : EntityTypeConfiguration<UserClaim>
	{
		public override void Configure(EntityTypeBuilder<UserClaim> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(UserClaim));
		}
	}
}