using AutoMapper;

namespace Coffee.Libs.Service
{
	public class MapTo<T>
	{
		public void Mapping(Profile profile) => profile.CreateMap(GetType(), typeof(T));
	}
}
