using Microsoft.EntityFrameworkCore.Diagnostics;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace Coffee.Libs.DataAccess.Oracle
{
	public class OracleCommandInterceptor : DbCommandInterceptor
	{
		public override InterceptionResult<DbDataReader> ReaderExecuting(
			DbCommand command,
			CommandEventData eventData,
			InterceptionResult<DbDataReader> result)
		{
			foreach (var param in command.Parameters)
			{
				var ora = param as OracleParameter;
				if (ora != null)
				{
					if (ora.DbType == System.Data.DbType.AnsiString && ora.Value?.GetType() == typeof(string))
					{
						ora.Value = ora.Value.ToString().PadRight(ora.Size, ' ');
					}
				}
			}
			return result;
		}
	}
}