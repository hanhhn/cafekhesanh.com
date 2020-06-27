﻿using Microsoft.EntityFrameworkCore;
using Coffee.Libs.DataAccess.Mapping;
using System.Reflection;

namespace Coffee.Libs.DataAccess.DbContext
{
	public class TablesBuilder
	{
		public static void Build(ModelBuilder modelBuilder)
		{
			//dynamically load all entity and query type configurations

			modelBuilder.ConfigureEntity(Assembly.GetExecutingAssembly());
		}
	}
}