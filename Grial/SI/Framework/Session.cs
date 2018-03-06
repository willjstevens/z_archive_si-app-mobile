using System;
using SI.Model;
using SI.Util;

namespace SI.Framework
{
	public class Session
	{
		public User user { get; set; }
		public SiHttpClient siHttpClient { get; set; }
		private string _httpSessionId;

		public bool hasDeviceSession()
		{
			var userId = this.userId;
			var deviceId = this.deviceId;
			return userId != null && deviceId != null;
		}

		public void cleanup()
		{
			this.user = null;
			this.httpSessionId = null;
			this.userId = null;
			this.deviceId = null;

			Settings.removeUserId();
			Settings.removeDeviceId();
		}

		public string httpSessionId
		{
			get {
				return _httpSessionId;
			}
			set {
				_httpSessionId = value;
			}
		}

		public string userId
		{
			get {
				return Settings.userId;
			}
			set {
				Settings.userId = value;
			}
		}

		public string deviceId
		{
			get {
				return Settings.deviceId;
			} 
			set {
				Settings.deviceId = value;
			}
		}



	}

}
