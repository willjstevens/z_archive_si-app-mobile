using Newtonsoft.Json;

namespace SI.Model
{
	public class Response
	{
		public bool success { get; set; }
		public string message { get; set; }
		public int code { get; set; }
		public object data { get; set; }
		public string error { get; set; }
		public string targetUrl { get; set; }
	}
}

