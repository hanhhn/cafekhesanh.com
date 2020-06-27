using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.Entities.Configuration;

namespace Coffee.DataAccess.Repository.Settings
{
	public interface ISettingRepository : IBaseRepository<Setting>
	{
		Setting FindByKey(string key);
	}
}