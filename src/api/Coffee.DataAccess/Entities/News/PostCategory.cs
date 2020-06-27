﻿using Coffee.Libs.DataAccess.EntityRoot;

namespace Coffee.DataAccess.Entities
{
	public class PostCategory : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
