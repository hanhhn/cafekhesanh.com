using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Coffee.Libs.DataAccess.Mapping;
using System.Reflection;

namespace Coffee.Libs.DataAccess.Oracle
{
	public class OracleEntityTypeConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
	{
		public override void Configure(EntityTypeBuilder<TEntity> builder)
		{
			PropertyInfo prop = typeof(TEntity).GetProperty("Id");
			if (prop != null)
			{
				builder.HasKey("Id");
			}
		}
	}
}