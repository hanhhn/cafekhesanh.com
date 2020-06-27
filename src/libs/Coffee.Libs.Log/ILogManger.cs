namespace Coffee.Libs.Log
{
	public interface ILogManger
	{
		void Information(string msg);
		void BeforeChanged(LogEventType action, string table, object data);
		void AfterChanged(LogEventType action, string table, object data);
	}
}
