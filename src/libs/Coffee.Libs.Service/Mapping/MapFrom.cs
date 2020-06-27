using AutoMapper;

namespace Coffee.Libs.Service
{
	public class MapFrom<T>
	{
		public void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
	}
}
