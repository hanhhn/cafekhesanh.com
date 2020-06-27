using System;

namespace Coffee.Libs.Core.Exeptions
{
	public class InformationException : SnpException
	{
		public InformationException(string msg) : base(msg)
		{
			ErrorCode = Common.ErrorCode.Information;
		}
	}
}