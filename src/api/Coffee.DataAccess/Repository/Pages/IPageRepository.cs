using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public interface IPageRepository : IBaseRepository<Page>
	{
		Page GetByUrl(string url);
	}
}