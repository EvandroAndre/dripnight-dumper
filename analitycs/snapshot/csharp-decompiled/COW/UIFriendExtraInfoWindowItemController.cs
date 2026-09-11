using GCommon;

namespace COW;

public class UIFriendExtraInfoWindowItemController : UIEasyListItemController
{
	private UIFriendExtraInfoWindowItemView m_View;

	private FriendAccountInfo m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(FriendAccountInfo accountInfo)
	{
	}

	private string GetDisplayName(FriendAccountInfo accountInfo)
	{
		return null;
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
