﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coffee.Libs.DataAccess.Mapping;
using Coffee.Libs.DataAccess.Identity.Entities;

namespace Coffee.Libs.DataAccess.Identity.Mapping
{
	public class AppUserRoleConfigure : EntityTypeConfiguration<AppUserRole>
	{
		public override void Configure(EntityTypeBuilder<AppUserRole> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(AppUserRole));
		}
	}
}
