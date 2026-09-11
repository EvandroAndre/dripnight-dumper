using System;
using GCommon;

namespace COW;

public class UIRelayMartDiscountCodeShareFriendItemController : UIEasyListItemController
{
	private UIRelayMartDiscountCodeShareFriendItemView m_View;

	private ERelayMartDiscountCodeShareChannelType m_ChannelType;

	private FriendAccountInfo m_Data;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelFriends m_ModelFriend;

	private UIModelChat m_ModelChat;

	private UIModelRelayMart m_ModelRelayMart;

	private ulong m_AccountId;

	private bool m_IsCoolingDown;

	private UIRelayMartDiscountCodeShareController m_ParentCtrl;

	public Action InviteCallback;

	private bool IsCollingDown
	{
		set
		{
		}
	}

	private UIRelayMartDiscountCodeShareController ParentCtrl => null;

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

	private void RefreshButtonState()
	{
	}

	private void OnBtnShareClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
