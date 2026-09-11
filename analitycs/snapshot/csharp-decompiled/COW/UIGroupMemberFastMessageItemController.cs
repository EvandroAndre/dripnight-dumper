using GCommon;

namespace COW;

internal class UIGroupMemberFastMessageItemController : UIEasyListItemController
{
	private UIGroupMemberFastMessageItemView m_View;

	private UIModelChat m_ModelChat;

	private AroundGameQuickChatData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnFastMessageButtonClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
