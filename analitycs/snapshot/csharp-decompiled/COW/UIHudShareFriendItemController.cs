using GCommon;

namespace COW;

public class UIHudShareFriendItemController : UIEasyListItemController
{
	private UIHUDShareFriendItemView m_View;

	private FriendAccountInfo m_Data;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelFriends m_ModelFriend;

	private UIModelChat m_ModelChat;

	private ulong m_AccountId;

	private bool m_IsCoolingDown;

	public string ShareCode;

	private EHudShareChannelType m_ChannelType;

	private const string LOG_TAG = "[UIHudShareFriendItemController]";

	private bool IsCoolingDown
	{
		set
		{
		}
	}

	private void RefreshButtonState()
	{
	}

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

	private ulong GetChannelId()
	{
		return 0uL;
	}

	private void OnBtnInviteClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
