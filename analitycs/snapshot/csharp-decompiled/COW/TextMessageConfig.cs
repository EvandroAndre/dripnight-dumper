namespace COW;

public static class TextMessageConfig
{
	public const int INVALID_SERVERZONE_ID = 9999;

	public static int ServerZoneID;

	public static string ServerAddr;

	public static bool IsAvailable => false;

	public static bool IsChatServerValid()
	{
		return false;
	}
}
