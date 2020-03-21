using Cf.Libs.Core.Infrastructure.Context;
using Cf.Libs.Core.Infrastructure.Engine;
using Microsoft.Extensions.DependencyInjection;

namespace Cf.Libs.Core
{
	public static class CfCoreRegister
    {
        public static void AddCoreService(this IServiceCollection services)
        {
            var engine = EngineContext.Current;
            engine.ConfigureServices(services.BuildServiceProvider());
			services.AddScoped<IIdentityContext, IdentityContext>();
		}
    }
}