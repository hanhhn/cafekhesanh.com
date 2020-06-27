﻿using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities.Common
{
	public class Tag : IEntityRoot
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}