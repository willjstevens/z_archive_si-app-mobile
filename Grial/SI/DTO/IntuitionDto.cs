using System;
using System.Collections.Generic;
using SI.Model;

namespace SI.DTO
{
	public class IntuitionDto
	{
<<<<<<< HEAD
		private Intuition intuition { get; set; }
		private bool isOwner { get; set; }
		private bool isInteractive { get; set; }
		private bool isActive { get; set; }
		private bool isCorrect { get; set; }
		private bool canVote { get; set; }
		private bool canContributeOutcome { get; set; }
		private bool canMakeSocialContributions { get; set; }
		private OutcomeDto cohortVotedOutcomeDto { get; set; }
		private LikeDto selfLikeDto { get; set; }
		private List<LikeDto> likeDtos { get; set; }
		private List<LikeDto> guestLikeDtos { get; set; }
		private List<CommentDto> commentDtos { get; set; }
		private List<OutcomeDto> potentialOutcomeDtos { get; set; }
		private OutcomeDto outcomeDto { get; set; }
		private string postPrettyTimestamp { get; set; }
		private string expirationPrettyTimestamp { get; set; }
		private string postTimestamp { get; set; }
		private string expirationTimestamp { get; set; }
=======
		public Intuition intuition { get; set; }
		public bool isOwner { get; set; }
		public bool isInteractive { get; set; }
		//public bool isActive { get; set; }
		public bool active { get; set; }
		public bool isCorrect { get; set; }
		public bool canVote { get; set; }
		public bool canContributeOutcome { get; set; }
		public bool canMakeSocialContributions { get; set; }
		public OutcomeDto cohortVotedOutcomeDto { get; set; }
		public LikeDto selfLikeDto { get; set; }
		public List<LikeDto> likeDtos { get; set; }
		public List<LikeDto> guestLikeDtos { get; set; }
		public List<CommentDto> commentDtos { get; set; }
		public List<OutcomeDto> potentialOutcomeDtos { get; set; }
		public OutcomeDto outcomeDto { get; set; }
		public string postPrettyTimestamp { get; set; }
		public string expirationPrettyTimestamp { get; set; }
		public string postTimestamp { get; set; }
		public string expirationTimestamp { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
