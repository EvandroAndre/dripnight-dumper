using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIPaymentSquadTreasureInviteItemDetailController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<proto.TopUpMember> _003C_003E9__16_0;

		internal int _003CRefreshMemberList_003Eb__16_0(proto.TopUpMember a, proto.TopUpMember b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public TopUpTeamInvitation data;

		internal bool _003CSetUIData_003Eb__0(proto.TopUpMember x)
		{
			return false;
		}
	}

	private UIPaymentSquadTreasureInviteItemDetailView m_View;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private FastSquadTreasureTeamShareMessage m_Message;

	private EChannel.ChannelType m_ChannelType;

	private TopUpTeamInvitation m_TeamInvitation;

	private proto.TopUpTeam m_ChannelTeam;

	private ESquadTreasureInviteItemDetailType m_ItemType;

	private List<UIPaymentSquadTreasureTeammateItemController> m_TeammateItemList;

	private int m_ChatChannelShareItemDetailDepth;

	private const int TEAMMATE_ITEM_DEPTH_TEAM_LIST_INVITE = 24;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(object info)
	{
	}

	public void SetTeamListInviteItemDetailDepth(int depth)
	{
	}

	private void InitTeammateItem()
	{
	}

	private void RefreshTeamName(string leaderName, ulong leaderAccountId)
	{
	}

	private void RefreshMemberList(List<proto.TopUpMember> memberList)
	{
	}

	private void OnBtnRejectClick()
	{
	}

	private void OnBtnAcceptClick()
	{
	}

	private void OnBtnViewClick()
	{
	}

	private void OnBtnJoinClick()
	{
	}

	private void RefreshButtonView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
