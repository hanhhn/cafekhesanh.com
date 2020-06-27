﻿using System.Collections.Generic;

namespace Coffee.Service.Dtos
{
	public class GuidePost
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public IEnumerable<PostDto> Posts { get; set; }
	}
}
