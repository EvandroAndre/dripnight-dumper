using message;

namespace COW;

public class FMetropolisMessageData
{
	public enum EStyle
	{
		Chat,
		System,
		Self
	}

	public string NickName;

	public AFBOKKIDEAB Faction;

	public uint HeadPic;

	public string TimeStr;

	public string Message;

	public EStyle Style;

	public void Clear()
	{
	}
}
