using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public interface ISettingRepository : IBaseRepository<Setting>
	{
		Setting FindByKey(string key);
	}
}