using System;

namespace Coffee.Libs.Core.Exeptions
{
	public class SnpException : Exception
	{
		public string ErrorCode { get; set; }

		public SnpException(string msg) : base(msg)
		{
			ErrorCode = Common.ErrorCode.Error;
		}
	}
}
