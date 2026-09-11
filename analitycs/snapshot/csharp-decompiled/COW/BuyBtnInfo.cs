namespace COW;

public class BuyBtnInfo
{
	public string icon;

	public string desc;

	public EventDelegate.Callback callback;

	public bool isSendGift;

	public BuyBtnInfo(string icon, string desc, EventDelegate.Callback callback, bool isSendGift = false)
	{
	}
}
