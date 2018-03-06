using System;
using System.Collections.Generic;

namespace SI.Model
{
	public class Comment
	{
<<<<<<< HEAD
		private string id { get; set; }
		private string commentText { get; set; }
		private List<Like> likes { get; set; }
		private string insertTimestamp { get; set; }
		private User user { get; set; }
=======
		public string id { get; set; }
		public string commentText { get; set; }
		public List<Like> likes { get; set; }
		public string insertTimestamp { get; set; }
		public User user { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
