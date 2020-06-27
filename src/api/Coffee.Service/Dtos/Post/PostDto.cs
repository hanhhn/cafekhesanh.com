﻿using System;
using System.Collections.Generic;

namespace Coffee.Service.Dtos
{
	public class PostDto
	{
		public string Id { get; set; }
		public string UniqueUrl { get; set; }
		public string Image { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Body { get; set; }
		public bool IsPublished { get; set; }
		public DateTime PublishedDate { get; set; }
		public IEnumerable<string> Tags { get; set; }
	}
}