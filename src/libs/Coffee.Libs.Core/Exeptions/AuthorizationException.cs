namespace Coffee.Libs.Core.Exeptions
{
	public class AuthorizationException : SnpException
	{
		public AuthorizationException(string msg) : base(msg)
		{
		}
	}
}