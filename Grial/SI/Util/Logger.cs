using System;
using System.Diagnostics;

namespace SI.Util
{
	public class Logger
	{
		private const bool DO_LOG = true;

		public static void info(string message)
		{
			Debug.WriteLine("INFO: " + message);
		}

		public static void warn(string message)
		{
			Debug.WriteLine("WARN: " + message);
		}

		public static void error(string message)
		{
			Debug.WriteLine("ERROR: " + message);
		}

		public static void error(string message, Exception exception)
		{
			Debug.WriteLine("ERROR: " + message);
			Debug.WriteLine(exception.ToString());
		}
	}
}

