﻿using Coffee.Libs.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Coffee.DataAccess.DbContext
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