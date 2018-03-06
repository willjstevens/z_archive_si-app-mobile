using System;
using System.Collections.Generic;

namespace SI.Model
{
	public class Intuition
	{
<<<<<<< HEAD
		private string id { get; set; }
		private User user { get; set; }
		private string intuitionText { get; set; }
		private string visibility { get; set; }
		private string predictionType { get; set; }
		private List<StoredImageInfo> imageInfos { get; set; }
		private List<Outcome> potentialOutcomes { get; set; }
		private Outcome predictedOutcome { get; set; }
		private Outcome outcome { get; set; }
		private bool scoreIntuition { get; set; }
		private bool displayPrediction { get; set; }
		private bool allowPredictedOutcomeVoting { get; set; }
		private bool allowCohortsToContributePredictedOutcomes { get; set; }
		private string activeWindow { get; set; }
		private List<Like> likes { get; set; }
		private List<Comment> comments { get; set; }
		private string insertTimestamp { get; set; }
		private string expirationTimestamp { get; set; }
		private long expirationMillis { get; set; }
=======
		public string id { get; set; }
		public User user { get; set; }
		public string intuitionText { get; set; }
		public string visibility { get; set; }
		public string predictionType { get; set; }
		public List<StoredImageInfo> imageInfos { get; set; }
		public List<Outcome> potentialOutcomes { get; set; }
		public Outcome predictedOutcome { get; set; }
		public Outcome outcome { get; set; }
		public bool scoreIntuition { get; set; }
		public bool displayPrediction { get; set; }
		public bool allowPredictedOutcomeVoting { get; set; }
		public bool allowCohortsToContributePredictedOutcomes { get; set; }
		public string activeWindow { get; set; }
		public List<Like> likes { get; set; }
		public List<Comment> comments { get; set; }
		public string insertTimestamp { get; set; }
		public string expirationTimestamp { get; set; }
		public long expirationMillis { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
