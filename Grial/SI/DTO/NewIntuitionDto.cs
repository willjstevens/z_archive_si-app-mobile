using System;
using System.Collections.Generic;
using SI.Model;

namespace SI.DTO
{
	public class NewIntuitionDto
	{
<<<<<<< HEAD
		private string defaultVisibility { get; set; }
		private string defaultPredictionType { get; set; }
		private List<ActiveWindow> activeWindows { get; set; }
		private List<Outcome> predictionChoicesYesNo { get; set; }
		private List<Outcome> predictionChoicesTrueFalse { get; set; }
		private bool scoreIntuition { get; set; }
		private bool displayPrediction { get; set; }
		private bool displayCohortsPredictions { get; set; }
		private bool allowPredictedOutcomeVoting { get; set; }
		private bool allowCohortsToContributePredictedOutcomes { get; set; }
=======
		public string defaultVisibility { get; set; }
		public string defaultPredictionType { get; set; }
		public List<ActiveWindow> activeWindows { get; set; }
		public List<Outcome> predictionChoicesYesNo { get; set; }
		public List<Outcome> predictionChoicesTrueFalse { get; set; }
		public bool scoreIntuition { get; set; }
		public bool displayPrediction { get; set; }
		public bool displayCohortsPredictions { get; set; }
		public bool allowPredictedOutcomeVoting { get; set; }
		public bool allowCohortsToContributePredictedOutcomes { get; set; }
>>>>>>> b01fe795a07a254709f2a981b38ac4c045d2071b
	}
}
