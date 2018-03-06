using System;
using System.Collections.Generic;
using SI.Model;

namespace SI.DTO
{
	public class CommentDto
	{
<<<<<<< HEAD
		private Comment comment { get; set; }
		private bool isOwner { get; set; }
		private LikeDto selfLikeDto { get; set; }
		private List<LikeDto> likeDtos { get; set; }
		private List<LikeDto> guestLikeDtos { get; set; }
		private string displayTimestamp { get; set; }
		private string postPrettyTimestamp { get; set; }
=======
		public Comment comment { get; set; }
		public bool isOwner { get; set; }
		public LikeDto selfLikeDto { get; set; }
		public List<LikeDto> likeDtos { get; set; }
		public List<LikeDto> guestLikeDtos { get; set; }
		public string displayTimestamp { get; set; }
		public string postPrettyTimestamp { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
