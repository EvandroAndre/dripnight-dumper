using GCommon;
using proto;

namespace COW;

public class UIMallV2GiftSendCheckTipItemController : UIBaseController
{
	private UIMallV2GiftSendCheckTipItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string name, CSCheckOwnedBeforeSendGiftRes.GiftSource giftSource)
	{
	}

	public int GetBGSize()
	{
		return 0;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
