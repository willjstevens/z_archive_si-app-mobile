using System;
using System.Collections.Generic;

namespace SI.Model
{
	public class Outcome
	{
<<<<<<< HEAD
		private string id { get; set; }
		private string predictionText { get; set; }
		private bool isIntuitionOwnerContributed { get; set; }
		private User contributorUser { get; set; }
		private bool isCorrect { get; set; }
		private bool wrongByExpiration { get; set; }
		private List<User> outcomeVoters { get; set; }
		private List<Like> likes { get; set; }
		private List<Comment> comments { get; set; }
		private string insertTimestamp { get; set; }
=======
		public string id { get; set; }
		public string predictionText { get; set; }
		public bool isIntuitionOwnerContributed { get; set; }
		public User contributorUser { get; set; }
		public bool isCorrect { get; set; }
		public bool wrongByExpiration { get; set; }
		public List<User> outcomeVoters { get; set; }
		public List<Like> likes { get; set; }
		public List<Comment> comments { get; set; }
		public string insertTimestamp { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
