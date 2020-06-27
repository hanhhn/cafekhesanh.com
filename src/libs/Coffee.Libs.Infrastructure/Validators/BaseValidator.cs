using FluentValidation;

namespace Coffee.Libs.Infrastructure
{
	public abstract class BaseValidator<TModel> : AbstractValidator<TModel> where TModel : class
	{
		protected BaseValidator()
		{
			Initialize();
		}

		protected virtual void Initialize()
		{
		}
	}
}
