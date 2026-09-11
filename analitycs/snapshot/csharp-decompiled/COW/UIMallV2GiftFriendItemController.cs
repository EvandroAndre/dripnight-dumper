using GCommon;

namespace COW;

public class UIMallV2GiftFriendItemController : UIEasyListItemController
{
	private UIMallV2GiftFriendItemView m_View;

	private FriendInfo m_Info;

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

	public void OnSendBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
