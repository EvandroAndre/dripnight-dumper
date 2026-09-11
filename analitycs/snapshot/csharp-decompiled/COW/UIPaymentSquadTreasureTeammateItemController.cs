using GCommon;
using proto;

namespace COW;

public class UIPaymentSquadTreasureTeammateItemController : UIBaseController
{
	private UIPaymentSquadTreasureTeammateItemView m_View;

	private UIModelClan m_ModelClan;

	private UIModelFriends m_ModelFriends;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private UIModelUser m_ModelUser;

	private ulong m_AccountId;

	private TopUpMember m_Info;

	private ESquadTreasureTeammateItemType m_ItemType;

	private bool m_IsEmpty;

	private bool m_IsLeader;

	public ulong AccountId => 0uL;

	public ulong SelfAccountId => 0uL;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(TopUpMember info, ESquadTreasureTeammateItemType itemType, bool isEmpty = false, bool isLeader = false)
	{
	}

	public void RefreshRoleView()
	{
	}

	public void RefreshLeaderIcon(bool isLeader)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public ulong GetAccountId()
	{
		return 0uL;
	}

	public void RefreshJoinFlush()
	{
	}

	public void PlayBlastVFX()
	{
	}

	public void PlayTopUpFinishInEffect()
	{
	}

	public void PlayTopUpFinishOutEffect()
	{
	}

	public void PlayUnLockEffect()
	{
	}

	public void ResetVFX()
	{
	}

	private void InitView()
	{
	}

	private void InitEvent()
	{
	}

	private void RefreshView()
	{
	}

	private void ResetView()
	{
	}

	private void RefreshMainPageView()
	{
	}

	private void RefreshTeammateName()
	{
	}

	private void RefreshTeamListView()
	{
	}

	private void RefreshTeamInfoView()
	{
	}

	private void RefreshNoticeWndView()
	{
	}

	private void RefreshInviteItemView()
	{
	}

	private void RefreshHeadIcon(AccountInfoBasic accountInfoBasic)
	{
	}

	private void RefreshMainPageProgressView(uint topUpAmount, ulong unlockDeadlineTimestamp)
	{
	}

	private void RefreshProgressViewOnlyCheckFinish(uint topUpAmount)
	{
	}

	private void RefreshUnFinishView(uint currentNum, ulong endTime)
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void OnBtnOpenBriefBoxClick()
	{
	}

	private void OnBtnJoinClick()
	{
	}

	private void OnBtnFriendClick()
	{
	}

	private void OnBtnClanClick()
	{
	}

	private void OnBtnAddFriendClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
