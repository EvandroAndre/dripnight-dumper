using GCommon;

namespace COW;

public static class DeviceIdentifier
{
	private const string DEVICE_IDENTIFIER_FORMAT = "{0}|{1}";

	private const string PLAYER_PREFS_KEY_ANDROID_DEVICE_IDENTIFIER = "AND_DEV_ID_0";

	private const string PROVIDER_GOOGLE = "Google";

	public static void Init()
	{
	}

	public static string Read()
	{
		return null;
	}

	private static void InitAndroid()
	{
	}

	private static void OnGetAdvertisingId(PlatformUtility_Android.GetAdvertisingIdResult result)
	{
	}

	private static void WriteAndroidDeviceIdentifier(string deviceIdentifier)
	{
	}

	private static string ReadAndroidDeviceIdentifier()
	{
		return null;
	}
}
