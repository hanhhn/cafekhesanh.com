using Coffee.Libs.DataAccess.Repository;
using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities.Common;

namespace Coffee.DataAccess.Repository.Provinces
{
	public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
	{
		public ProvinceRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}