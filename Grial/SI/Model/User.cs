using System;

namespace SI.Model
{
	public class User
	{

		public string id { get; set; }
		public string username { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string fullName { get; set; }
		public StoredImageInfo imageInfo { get; set; }
		public string email { get; set; }
		//public Date birthdate { get; set; }
		public string gender { get; set; }
		public string password { get; set; }
		public string passwordQuestion { get; set; }
		public string passwordAnswer { get; set; }
		public string timezone { get; set; }
		public string cookieValue { get; set; }
		public string registrationSource { get; set; }
		public string verificationCode { get; set; }
		public string verificationCodeIssuedTimestamp { get; set; }
		public string verificationCodeCompletedTimestamp { get; set; }
		public bool agreement { get; set; }
		public bool guest { get; set; }
		public bool unidentified { get; set; }
		public bool enabled { get; set; }
		public bool admin { get; set; }
		public bool deleted { get; set; }
		public string insertTimestamp { get; set; }
		//public Date updateTimestamp { get; set; }
		//public Date deleteTimestamp { get; set; }


	}
}

