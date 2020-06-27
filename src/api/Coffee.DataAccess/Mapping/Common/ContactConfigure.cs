using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.DataAccess.Mapping.Common
{
	public class ContactConfigure : PostgreEntityTypeConfiguration<Contact>
	{
		public override void Configure(EntityTypeBuilder<Contact> builder)
		{
			base.Configure(builder);

			builder.ToTable(nameof(Contact));
		}
	}
}