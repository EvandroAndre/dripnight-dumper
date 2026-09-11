using GCommon;
using tcp;

namespace COW;

public class UIChatMessageItemRoomInviteController : UIBaseController
{
	private UIChatMessageItemRoomInviteView m_View;

	private FastRoomRecruitMessage m_MessageInfoFastRoomRecruit;

	private MessageInfo m_MessageInfo;

	private EChannel.ChannelType m_ChannelType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(MessageInfo info, EChannel.ChannelType channelType)
	{
	}

	private void OnRoomJoinBtnClick()
	{
	}

	private void OnRoomJoinSecondConfirmSuccess()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
