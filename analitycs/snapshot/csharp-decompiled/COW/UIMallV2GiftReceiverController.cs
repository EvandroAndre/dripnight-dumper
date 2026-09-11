using GCommon;

namespace COW;

public class UIMallV2GiftReceiverController : UIBaseController
{
	protected UIMallV2GiftReceiverLeftView m_View;

	protected FriendInfo m_FriendInfo;

	protected int m_Index;

	private UIModelGift m_ModelGift;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(FriendInfo friendInfo, int data_index)
	{
	}

	public void RefreshData(FriendInfo data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
