using System;

namespace Coffee.Libs.Core.Exeptions
{
	public class DataValidationException : SnpException
	{
		public DataValidationException(string msg) : base(msg)
		{
			ErrorCode = Common.ErrorCode.Validation;
		}
	}
}