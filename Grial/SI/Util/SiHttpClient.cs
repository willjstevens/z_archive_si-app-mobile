using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SI.Model;
using SI.Framework;

namespace SI.Util
{

	public class SiHttpClient
	{
		public Session session { private get; set; } 

		private const string DOMAIN = "http://localhost:8080";
		//private const string DOMAIN = "http://192.168.1.71:8080";
		//private const string DOMAIN = "http://172.31.98.251:8080";
		private const string SERVER_URI = DOMAIN + "/api";

		public Task<Response> login(User user)
		{
			Task<Response> response = null;
			string endpoint = "/login";
			response = postJson(endpoint, user);
			return response;
		}

		public Task<Response> loginByDeviceSession()
		{
			Task<Response> response = null;
			string endpoint = "/login/device-session";
			response = postJson(endpoint, "");
			return response;
		}

		public Task<Response> logout()
		{
			Task<Response> response = null;
			string endpoint = "/logout";
			response = postJson(endpoint, "");
			return response;
		}

		public Task<Response> fetchActivityFeed(int start, int quantity)
		{
			Task<Response> response = null;
			string endpoint = "/intuition/fetch/activity";
			endpoint += "?start=" + start + "&quantity=" + quantity;
			response = getJson2(endpoint);
			return response;
		}

		private async Task<string> getJson(string endpoint)
		{
			var json = "UNINITIALIZED JSON";
			using (var client = new HttpClient()) {
				try {
					var response = await client.GetAsync(SERVER_URI + endpoint);
					if (response.IsSuccessStatusCode) {
						json = await response.Content.ReadAsStringAsync();
						Logger.info("Called " + endpoint + " with JSON: " + json);
					} else {
						Logger.warn("Got error response from endpoint call: " + response.StatusCode + " " + response.ReasonPhrase);
					}
				} catch (Exception e) {
					Logger.error("Problem when calling endpoint: " + endpoint, e);
				}
			}
			return json;
		}

		private async Task<Response> getJson2(string endpoint)
		{
			Response response = null;

			CookieContainer cookies = new CookieContainer();
			HttpClientHandler handler = new HttpClientHandler();
			handler.CookieContainer = cookies;

			Uri target = new Uri(DOMAIN);

			using (var client = new HttpClient(handler)) {

				if (this.session.httpSessionId != null) {
					cookies.Add(target, new Cookie("JSESSIONID", session.httpSessionId));
				}

				try {
					// there is only a userId if a session is set, but none if not logged in
					if (this.session.userId != null) {
						client.DefaultRequestHeaders.Add("userId", this.session.userId);
					}
					// there should always be a deviceId
					client.DefaultRequestHeaders.Add("deviceId", this.session.deviceId);

					//var serializerSettings = new JsonSerializerSettings();
					//serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
					//var jsonString = JsonConvert.SerializeObject(body, serializerSettings);
					//var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

					var url = SERVER_URI + endpoint;
					Logger.info("About to call endpoint URL: " + url);

					var getResponse = await client.GetAsync(url);

					var headers = getResponse.Headers;
					if (headers.Contains("httpSessionId")) {
						this.session.httpSessionId = headers.GetValues("httpSessionId").First();
					}

					if (getResponse.IsSuccessStatusCode) {
						var jsonResponse = await getResponse.Content.ReadAsStringAsync();
						response = JsonConvert.DeserializeObject<Response>(jsonResponse);
						Logger.info("Called " + endpoint + " with JSON: " + jsonResponse);
					} else {
						Logger.warn("Got error response from endpoint call: " + getResponse.StatusCode + " " + getResponse.ReasonPhrase);
					}
				} catch (Exception e) {
					Logger.error("Problem when calling endpoint: " + endpoint, e);
				}
			}
			return response;
		}

		private async Task<Response> postJson(string endpoint, object body)
		{
			Response response = null;

			CookieContainer cookies = new CookieContainer();
			HttpClientHandler handler = new HttpClientHandler();
			handler.CookieContainer = cookies;

			Uri target = new Uri(DOMAIN);

			using (var client = new HttpClient(handler)) {

				if (this.session.httpSessionId != null) {
					cookies.Add(target, new Cookie("JSESSIONID", session.httpSessionId));
				}

				try {
					// there is only a userId if a session is set, but none if not logged in
					if (this.session.userId != null) {
						client.DefaultRequestHeaders.Add("userId", this.session.userId);
					}
					// there should always be a deviceId
					client.DefaultRequestHeaders.Add("deviceId", this.session.deviceId);

					var serializerSettings = new JsonSerializerSettings();
					serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
					var jsonString = JsonConvert.SerializeObject(body, serializerSettings);
					var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

					var url = SERVER_URI + endpoint;
					Logger.info("About to call endpoint URL: " + url);

					var postResponse = await client.PostAsync(url, content);

					var headers = postResponse.Headers;
					if (headers.Contains("httpSessionId")) {
						this.session.httpSessionId = headers.GetValues("httpSessionId").First();
					}

					if (postResponse.IsSuccessStatusCode) {
						var jsonResponse = await postResponse.Content.ReadAsStringAsync();
						response = JsonConvert.DeserializeObject<Response>(jsonResponse);
						Logger.info("Called " + endpoint + " with JSON: " + jsonString);
					} else {
						Logger.warn("Got error response from endpoint call: " + postResponse.StatusCode + " " + postResponse.ReasonPhrase);
					}
				} catch (Exception e) {
					Logger.error("Problem when calling endpoint: " + endpoint, e);
				}
			}
			return response;
		}

		public async Task<string> getVal()
		{
			var result = "NOTHING YET";
			//Task<string> result = null;

			var restUrl = "http://localhost:8080/hello";
			var uri = new Uri(string.Format(restUrl, string.Empty));

			//System.Net. ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };


			HttpClient client = new HttpClient();


			//client.
			//client.MaxResponseContentBufferSize = 256000;
			var response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode) {
				result = await response.Content.ReadAsStringAsync();
				//result = await Task.Run(() => response.Content.ReadAsStringAsync());

				Debug.WriteLine("**** Response is: " + result);

				//Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
			}

			return result;
		}

	}

}

