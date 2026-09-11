using GCommon;

namespace COW;

public class UIHudUGCSocialController : UIBaseController, IUIModelDataChangeObserver
{
	private const uint VISIBILITY_STATE_CAMERAMODE = 1073741824u;

	private UIHudUGCSocialView m_View;

	private UIModelInGameChat m_ModelChat;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private UIInGameChatParentController m_ChatController;

	private int m_MessageLabelOrigWidth;

	private uint m_MessageDispearCallID;

	private bool m_IsShowUGCLobbyContainer;

	private UITipsNormalController m_ChatRedPoint;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void RefreshUGCLobbyShowState(bool state)
	{
	}

	private void OnChatClick()
	{
	}

	private void OnChatMessageBtnClick()
	{
	}

	private void OnFriendListBtnClick()
	{
	}

	private void ShowChatController()
	{
	}

	private void RefreshLatestMessage()
	{
	}

	private void OnChatMessageLabelScrollFinish()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
