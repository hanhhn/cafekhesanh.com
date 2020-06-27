using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Configuration;
using System.Linq;

namespace Coffee.DataAccess.Repository.Settings
{
	public class SettingRepository : BaseRepository<Setting>, ISettingRepository
	{
		public SettingRepository(ApplicationDbContext context) : base(context)
		{
		}

		public Setting FindByKey(string key)
		{
			return DbSet.Where(x => x.Name == key).SingleOrDefault();
		}
	}
}