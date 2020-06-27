namespace Coffee.Libs.Core.Exeptions
{
	public class PageNotFoundException : SnpException
	{
		public PageNotFoundException(string msg) : base(msg)
		{
		}
	}
}