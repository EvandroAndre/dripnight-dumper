using GCommon;

namespace COW;

public class UIFastSendGiftFriendItemController : UIEasyListItemController
{
	private UIFastSendGiftFriendItemView m_View;

	private FriendInfo m_Info;

	private UIModelGift m_ModelGift;

	private UIModelFriends m_ModelFriends;

	private UIMallV2IntimacyProfileInfoController m_IntimacyProfileController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshData(FriendInfo data)
	{
	}

	public void OnInfoBtnClick()
	{
	}

	public FriendInfo GetInfo()
	{
		return null;
	}

	public void SetIsSelected(bool isSelected)
	{
	}

	public void SetIsPrimeGift(bool isPrimeGift)
	{
	}

	public void RefreshIntimacyValue()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
