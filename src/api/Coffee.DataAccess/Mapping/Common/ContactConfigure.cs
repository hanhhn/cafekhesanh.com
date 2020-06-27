using Coffee.DataAccess.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class ContactConfigure : EntityTypeConfiguration<Contact>
	{
		public override void Configure(EntityTypeBuilder<Contact> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Contact));
		}
	}
}