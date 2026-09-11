using GCommon;
using tcp;

namespace COW;

public class UIBigEventChatMsgItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIBigEventChatMsgItemView m_View;

	private UIModelBigEvent m_ModelBigEvent;

	private MessageInfo m_MsgInfo;

	private FastBigEventMsg m_BigEventMsgInfo;

	private EBigEventChatMsgType m_CurType;

	private EChannel.ChannelType m_Channel;

	private bool m_IsSelf;

	private bool m_BtnGiveClicked;

	private const uint MAX_SUB_GROUP_CNT = 2u;

	private ulong m_SenderID;

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

	public void SetViewData(MessageInfo msgInfo, bool isSelf, EChannel.ChannelType channel, ulong senderID = 0uL)
	{
	}

	private void SetJumpsuit2BView(string serializedInfo)
	{
	}

	private void OnBtnJoinClick()
	{
	}

	private void OnBtnGiveClick()
	{
	}

	private void SendGiveMsg()
	{
	}

	private void OnBtnNavigateClick()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
