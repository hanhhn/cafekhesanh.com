using Microsoft.EntityFrameworkCore;

namespace Coffee.DataAccess.Mapping
{
	public partial interface IMappingConfiguration
	{
		void ApplyConfiguration(ModelBuilder modelBuilder);
	}
}
