using System;
using SI.Framework;
using SI.Model;
using SI.DTO;
using SI.Util;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SI.Service
{
	public class IntuitionService
	{
		public Session session { private get; set; }
		public SiHttpClient siHttpClient { get; set; }


		public Task<Response> fetchActivityFeed(int start, int quantity)
		{
			var networkClient = session.siHttpClient;
			return networkClient.fetchActivityFeed(start, quantity);
		}



		//public Task<Response> loginByUsernamePassword(string username, string password)
		//{
		//	var user = new SI.Model.User();
		//	user.username = username;
		//	user.password = password;
		//	var networkClient = session.siHttpClient;

		//	// assign a new "deviceId" on username/password login
		//	session.deviceId = System.Guid.NewGuid().ToString();

		//	return networkClient.login(user);
		//}

		//public Task<Response> loginByDeviceSession()
		//{
		//	var networkClient = session.siHttpClient;
		//	return networkClient.loginByDeviceSession();
		//}


	}
}

