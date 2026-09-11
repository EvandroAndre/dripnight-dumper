using GCommon;

namespace COW;

public class UIFriendBatchRemoveFriendItemController : UIEasyListItemController
{
	private UIFriendBatchRemoveFriendItemView m_View;

	private FriendAccountInfo m_Data;

	private UIFriendBatchRemoveFriendController m_parent;

	private UIBaseProfileInfoController m_baseInfo;

	private UIFriendBatchRemoveFriendController ParentCtrl => null;

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

	public void OnSelectBtnClick()
	{
	}

	public void OnAllSelectClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
