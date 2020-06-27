using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.News
{
	public class PostConfigure : PostgreEntityTypeConfiguration<Post>
	{
		public override void Configure(EntityTypeBuilder<Post> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Post));
		}
	}
}