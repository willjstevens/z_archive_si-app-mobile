using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SI.Util
{
	// See here for plugin home page: https://github.com/jamesmontemagno/SettingsPlugin
	public static class Settings
	{
		private const string userIdKey = "userId";
		private const string deviceIdKey = "deviceId";


		//private static readonly string DEVICE_ID_DEFAULT = System.Guid.NewGuid().ToString();

		private static ISettings appSettings
		{
			get {
				return CrossSettings.Current;
			}
		}

		public static string userId
		{
			get { return appSettings.GetValueOrDefault<string>(userIdKey, null); }
			set { appSettings.AddOrUpdateValue<string>(userIdKey, value); }
		}

		public static string deviceId
		{
			get { return appSettings.GetValueOrDefault<string>(deviceIdKey, null); }
			set { appSettings.AddOrUpdateValue<string>(deviceIdKey, value); }
		}

		public static string hello
		{
			get { return appSettings.GetValueOrDefault<string>("hello", null); }
			set { appSettings.AddOrUpdateValue<string>("hello", value); }
		}

		public static void removeUserId()
		{
			appSettings.Remove(userIdKey);
		}

		public static void removeDeviceId()
		{
			appSettings.Remove(deviceIdKey);
		}
	}
}
