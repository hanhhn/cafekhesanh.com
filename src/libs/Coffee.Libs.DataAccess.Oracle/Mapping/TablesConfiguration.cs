using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Coffee.Libs.DataAccess.Oracle
{
	public static class TablesConfiguration
	{
		public static void OracleConfigureEntity(this ModelBuilder modelBuilder, Assembly instance)
		{
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				foreach (var property in entityType.GetProperties())
				{
					var memberInfo = property.PropertyInfo ?? (MemberInfo)property.FieldInfo;
					if (memberInfo == null)
						continue;

					if (property.PropertyInfo?.PropertyType == typeof(string))
						property.SetIsUnicode(false);

					var classAttribute = Attribute.GetCustomAttribute(memberInfo, typeof(ScalarPropertyAttribute)) as ScalarPropertyAttribute;

					if (classAttribute == null)
						continue;

					if (!string.IsNullOrEmpty(classAttribute.DbColumnName))
						property.SetColumnName(classAttribute.DbColumnName);

					if (classAttribute.DbDataLength > 0)
						property.SetMaxLength(classAttribute.DbDataLength);
				}
			}
		}
	}
}
