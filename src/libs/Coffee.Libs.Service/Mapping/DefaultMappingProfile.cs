using AutoMapper;
using Coffee.Libs.Infrastructure;
using System;
using System.Linq;
using System.Reflection;

namespace Coffee.Libs.Service
{
	public class DefaultMappingProfile : Profile
	{
		public DefaultMappingProfile()
		{
			CreateMap(typeof(PagedList<>), typeof(PagedList<>));

			ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
		}

		private void ApplyMappingsFromAssembly(Assembly assembly)
		{
			var types = assembly.GetExportedTypes()
				.Where(t => t.IsGenericType && (t.GetGenericTypeDefinition() == typeof(MapTo<>) || t.GetGenericTypeDefinition() == typeof(MapFrom<>)))
				.ToList();

			foreach (var type in types)
			{
				var instance = Activator.CreateInstance(type);
				var methodInfo = type.GetMethod("Mapping");
				methodInfo?.Invoke(instance, new object[] { this });
			}
		}
	}
}