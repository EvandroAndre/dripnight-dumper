using COW.Gameplay.UGC;

namespace COW;

public class VoiceToTextGIConfig
{
	public EUGCGICMDID CmdID;

	public int RequestTimeout;

	public string Region;

	public static VoiceToTextGIConfig CreateDefault()
	{
		return null;
	}

	public int GetRequestTimeout()
	{
		return 0;
	}

	public string GetRegion()
	{
		return null;
	}
}
