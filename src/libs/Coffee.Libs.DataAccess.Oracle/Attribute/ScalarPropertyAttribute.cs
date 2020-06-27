using System;

namespace Coffee.Libs.DataAccess.Oracle
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ScalarPropertyAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets the value that indicates whether the property is a key.
		/// </summary>
		public bool EntityKeyProperty { get; set; }

		/// <summary>
		/// Gets or sets the value that indicates whether the property can have a null
		/// value.
		/// </summary>
		public bool IsRequired { get; set; }

		/// <summary>
		/// Gets or sets the name of associated db column name
		/// </summary>
		public string DbColumnName { get; set; }

		/// <summary>
		/// Gets or sets the column's display name
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// Gets or sets the length of db column size
		/// </summary>
		public int DbDataLength { get; set; }

		/// <summary>
		/// Get or set the flag indicate the property is setted value or not
		/// </summary>
		public bool IsSetValue { get; set; }

		/// <summary>
		/// If property is set as YesBoolType, then Y = true, otherwise means false
		/// </summary>
		public bool YesBoolType { get; set; }

		/// <summary>
		/// Set flag this field is key link in audit when insert/update/delete
		/// </summary>
		public bool AuditPrimaryKey { get; set; }

		/// <summary>
		/// Set flag this field is key link in audit when insert/update/delete
		/// </summary>
		public bool AuditSecondaryKey { get; set; }

		/// <summary>
		/// Set flag this field need audit when insert/update/delete
		/// </summary>
		public bool IsNeedAudit { get; set; }

		/// <summary>
		/// Detemine this column is container column name
		/// </summary>
		public bool IsItemNoCol { get; set; }

		/// <summary>
		/// If Yes: need delete single quote when mapping
		/// </summary>
		public bool IsTruncateIntf { get; set; }

		/// <summary>
		/// Indicate whether db column is history flag
		/// </summary>
		public bool IsHistoryFlag { get; set; }

		/// <summary>
		/// Gets or sets the value that indicates this field must be in search condition.
		/// </summary>
		public bool MandatorySearchField { get; set; }

		/// <summary>
		/// Gets or sets the value that indicates number of days limited (in case of MandatorySearchField set to true and is datetime field).
		/// </summary>
		public int DaysLimited { get; set; }

		public bool IsAcceptedNonAscii { get; set; }
	}
}
