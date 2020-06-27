﻿using Coffee.DataAccess.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class AddressConfigure : EntityTypeConfiguration<Address>
	{
		public override void Configure(EntityTypeBuilder<Address> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Address));
		}
	}
}