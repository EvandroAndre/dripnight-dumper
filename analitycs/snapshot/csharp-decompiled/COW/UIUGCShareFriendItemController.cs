using System;
using GCommon;

namespace COW;

internal class UIUGCShareFriendItemController : UIEasyListItemController
{
	private UIUGCShareFriendItemView m_View;

	private FriendAccountInfo m_Data;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelFriends m_ModelFriend;

	private UIModelChat m_ModelChat;

	private ulong m_AccountId;

	private bool m_IsCoolingDown;

	public Action InviteCallback;

	public string ShareCode;

	private bool IsCollingDown
	{
		set
		{
		}
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

	private void OnBtnInviteClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
