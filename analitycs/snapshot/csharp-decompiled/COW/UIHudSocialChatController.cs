using GCommon;
using tcp;

namespace COW;

public class UIHudSocialChatController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
{
	private const uint VISIBILITY_STATE_CAMERAMODE = 1073741824u;

	private UIHudSocialChatView m_View;

	private UIModelChat m_ModelChat;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIChatParentController m_ChatController;

	private int m_MessageLabelOrigWidth;

	private uint m_MessageDispearCallID;

	private bool m_IsCustomRoom;

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

	public void SetIsCustomRoom(bool isCustomRoom)
	{
	}

	private void OnCameraModeChanged(bool isOpen)
	{
	}

	private void OnChatClick()
	{
	}

	private void OnChatMessageBtnClick()
	{
	}

	private void ShowChatController(EChannel.ChannelType toChannel, ulong roomId = 0uL)
	{
	}

	private void OnRecruitTeammateBtn()
	{
	}

	private void OnChatRecruitBtnClick()
	{
	}

	private void RefreshLatestMessage()
	{
	}

	private void OnChatMessageLabelScrollFinish()
	{
	}

	private void RefreshRecruitBtn(object[] data)
	{
	}

	private void OnChatGroupInfoChange()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
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
