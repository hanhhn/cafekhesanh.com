using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Coffee.Libs.Infrastructure
{
	public static class ValidationConfigure
	{
		public static IMvcBuilder AddCustomValidation(this IMvcBuilder mvcBuilder, Type type)
		{
			mvcBuilder.AddFluentValidation(options =>
			{
				options.RunDefaultMvcValidationAfterFluentValidationExecutes = true;
				options.ConfigureClientsideValidation(enabled: false);
				options.RegisterValidatorsFromAssemblyContaining(type);
			});

			return mvcBuilder;
		}
	}
}
