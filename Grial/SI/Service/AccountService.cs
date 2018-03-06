using System;
using SI.Framework;
using SI.Model;
using SI.DTO;
using SI.Util;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SI.Service
{
	public class AccountService
	{
		public Session session { private get; set; }
		public SiHttpClient siHttpClient { get; set; }

		public Task<Response> loginByUsernamePassword(string username, string password)
		{
			var user = new SI.Model.User();
			user.username = username;
			user.password = password;
			var networkClient = session.siHttpClient;

			// assign a new "deviceId" on username/password login
			session.deviceId = System.Guid.NewGuid().ToString();

			return networkClient.login(user);
		}

		public Task<Response> loginByDeviceSession()
		{
			var networkClient = session.siHttpClient;
			return networkClient.loginByDeviceSession();
		}

		public Task<Response> logout()
		{

			var networkClient = session.siHttpClient;
			Task<Response> taskResponse = networkClient.logout();

			return taskResponse;
		}

		public void resetSessionInfo(Response response)
		{
			DeviceLoginDto deviceLoginDto = JsonConvert.DeserializeObject<DeviceLoginDto>(response.data.ToString());
			session.user = deviceLoginDto.user;
			session.userId = deviceLoginDto.deviceSession.userId;
			session.deviceId = deviceLoginDto.deviceSession.deviceId;
			session.httpSessionId = deviceLoginDto.deviceSession.httpSessionId;
		}
	}
}

