using GCommon;

namespace COW;

public class UIChatMessageItemTipsController : UIBaseController
{
	private UIChatMessageItemTipsView m_View;

	private MessageInfo m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(MessageInfo info)
	{
	}

	public void SetUIData(ClientInGameChatMessage info)
	{
	}

	private void OnQuickAddFriendBtnClick()
	{
	}

	private void OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
