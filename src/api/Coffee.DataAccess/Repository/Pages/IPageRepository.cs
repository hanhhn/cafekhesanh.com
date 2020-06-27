using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.Entities;

namespace Coffee.DataAccess.Repository.Pages
{
	public interface IPageRepository : IBaseRepository<Page>
	{
		Page GetByUrl(string url);
	}
}