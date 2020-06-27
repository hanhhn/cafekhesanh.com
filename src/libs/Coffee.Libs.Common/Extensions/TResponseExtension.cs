using Coffee.Libs.Common.Types;

namespace Coffee.Libs.Common.Extensions
{
	public static class TResponseExtension
	{
		public static bool HasData<T>(this TResponse<T> response)
		{
			return response != null && response.Succeed && response.Data != null;
		}

		public static bool Succeed<T>(this TResponse<T> response)
		{
			return response != null && response.Succeed;
		}

		public static string[] Error<T>(this TResponse<T> response)
		{
			if (!response.Succeed())
				return response.Errors;

			return default(string[]);
		}
	}
}
