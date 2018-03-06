using System;
using System.Collections.Generic;
using SI.Model;

namespace SI.DTO
{
	public class ScoreDto
	{
<<<<<<< HEAD
		private Score score { get; set; }
		private int ownedPercent { get; set; }
		private int cohortPercent { get; set; }
		private int totalPercent { get; set; }
		private int total { get; set; }
		private int totalCorrect { get; set; }
		private int ownedTotal { get; set; }
		private int cohortTotal { get; set; }
		private List<Intuition> allOwned { get; set; }
		private List<Intuition> allCohort { get; set; }
=======
		public Score score { get; set; }
		public int ownedPercent { get; set; }
		public int cohortPercent { get; set; }
		public int totalPercent { get; set; }
		public int total { get; set; }
		public int totalCorrect { get; set; }
		public int ownedTotal { get; set; }
		public int cohortTotal { get; set; }
		public List<Intuition> allOwned { get; set; }
		public List<Intuition> allCohort { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
