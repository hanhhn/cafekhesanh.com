using Coffee.DataAccess.Entities.News;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.News
{
	public class PostConfigure : EntityTypeConfiguration<Post>
	{
		public override void Configure(EntityTypeBuilder<Post> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Post));
		}
	}
}