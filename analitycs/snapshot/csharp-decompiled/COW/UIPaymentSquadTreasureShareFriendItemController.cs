using System;
using GCommon;

namespace COW;

public class UIPaymentSquadTreasureShareFriendItemController : UIEasyListItemController
{
	private UIPaymentSquadTreasureShareFriendItemView m_View;

	private FriendAccountInfo m_Data;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelFriends m_ModelFriend;

	private UIModelChat m_ModelChat;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private ulong m_AccountId;

	private bool m_IsCoolingDown;

	public Action InviteCallback;

	private ESquadTreasureShareChannelType m_ChannelType;

	private bool m_IsInTeam;

	private UIPaymentSquadTreasureShareController m_ParentCtrl;

	private bool IsCollingDown
	{
		set
		{
		}
	}

	private UIPaymentSquadTreasureShareController ParentCtrl => null;

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

	private void OnBtnInviteClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
