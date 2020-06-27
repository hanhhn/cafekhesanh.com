using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class TagConfigure : PostgreEntityTypeConfiguration<Tag>
	{
		public override void Configure(EntityTypeBuilder<Tag> builder)
		{
			base.Configure(builder);
			builder.ToTable(nameof(Tag));
		}
	}
}