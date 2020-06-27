using System;

namespace Coffee.Libs.DataAccess.Oracle
{
	/// <summary>
	/// Attribute that indicates that the property represents a scalar property.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ScalarClassAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets the name of associated db table name
		/// </summary>
		public string DbTableName { get; set; }

		/// <summary>
		/// Gets or sets the excel template name 
		/// </summary>
		public string ExcelTemplateType { get; set; }

		/// <summary>
		/// Set flag this table need audit when insert/update/delete
		/// </summary>
		public bool IsNeedAudit { get; set; }

		/// <summary>
		/// Ste the type of audit data: ITEM, PREGATE, DISCHARGE_LIST, BAPLIE, EDI_ITEM_
		/// </summary>
		public string AuditDataType { get; set; }

		/// <summary>
		/// Indicates a view to be used in global search
		/// </summary>
		public bool IsFilterViewSource { get; set; }

		/// <summary>
		/// Indicates whether supports searching on history and active record
		/// </summary>
		public bool IsHistorySearchSupport { get; set; }

		/// <summary>
		/// Indicates name of view to be displayed
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// Indicates number of rows restricted.
		/// </summary>
		public int RestrictedRowNum { get; set; }


	}
}
