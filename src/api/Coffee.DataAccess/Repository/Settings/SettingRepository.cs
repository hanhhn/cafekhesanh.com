using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;
using System.Linq;

namespace Coffee.DataAccess.Repository
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