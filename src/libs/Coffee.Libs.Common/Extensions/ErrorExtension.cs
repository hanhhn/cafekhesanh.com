using Coffee.Libs.Common.Types;
using System.Collections.Generic;
using System.Linq;

namespace Coffee.Libs.Common.Extensions
{
	public static class ErrorExtension
	{
		public static bool HasError(this List<Message> messages)
		{
			return messages != null && messages.Any();
		}
	}
}
