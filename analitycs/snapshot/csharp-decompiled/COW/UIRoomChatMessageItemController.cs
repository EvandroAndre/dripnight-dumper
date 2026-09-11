using GCommon;

namespace COW;

public class UIRoomChatMessageItemController : UIBaseController
{
	private UIRoomChatMessageItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(MessageInfo messageInfo, ulong roomCreaterID)
	{
	}

	private string GetRoomWinRatePreviewText(MessageInfo messageInfo)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
