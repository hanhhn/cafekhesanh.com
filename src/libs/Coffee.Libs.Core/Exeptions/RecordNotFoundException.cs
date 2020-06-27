using System;

namespace Coffee.Libs.Core.Exeptions
{
	/// <summary>
	/// Throw new exception when do not found record in database
	/// </summary>
	public class RecordNotFoundException : SnpException
	{
		public RecordNotFoundException(string name, object key)
			: base($"Entity \"{name}\" ({key}) was not found.")
		{
			ErrorCode = Common.ErrorCode.RecordNotFound;
		}
	}
}