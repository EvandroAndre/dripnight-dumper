using GCommon;

namespace COW;

internal class UIRelationshipFriendInfoItemContoller : UIEasyListItemController
{
	private UIBaseProfileInfoController uIBaseProfileInfo;

	private UIRelationshipFriendInfoItemView m_View;

	private FriendAccountInfo m_friendInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnChooseItemClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
