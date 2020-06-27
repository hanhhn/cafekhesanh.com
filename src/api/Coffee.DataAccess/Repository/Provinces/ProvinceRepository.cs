using Coffee.DataAccess.DbContext;
using Coffee.DataAccess.Entities;
using Coffee.Libs.DataAccess.Repository;

namespace Coffee.DataAccess.Repository
{
	public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
	{
		public ProvinceRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}