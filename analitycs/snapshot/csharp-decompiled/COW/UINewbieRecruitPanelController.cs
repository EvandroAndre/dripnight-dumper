using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

internal class UINewbieRecruitPanelController : UIBaseController
{
	private enum RecruitTag
	{
		KD,
		Streak,
		WinRate,
		HeadShot
	}

	private const string CLICK_KEY_NEWBIE_RECRUIT_RECOMMEND_JOIN_CLICK = "NewbieRecruitRecommendJoinClick";

	private const string CLICK_KEY_NEWBIE_RECRUIT_ONE_KEY_SEND_CLICK = "NewbieRecruitOneKeySendClick";

	private UINewbieRecruitPanelView m_View;

	private UIModelGroup m_ModelGroup;

	private bool m_HasRecommendTeam;

	private GroupRecruitTeamInfo m_RecommendTeamInfo;

	private bool m_IsWaitingRecommendJoinResult;

	private bool m_HasTriggeredQuickJoinFallback;

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

	public void ShowPanel(bool show)
	{
	}

	public void RefreshRecommendInfo(GroupNewbieRecruitTeamNtf ntf)
	{
	}

	private void RefreshMemberCountLabel(GroupRecruitTeamInfo teamInfo)
	{
	}

	private RecruitTeamMemberHighLight GetLeaderHighlight(GroupRecruitTeamInfo teamInfo)
	{
		return null;
	}

	private List<RecruitTag> SelectTags(float kd, uint streak, float winRate, float headShot)
	{
		return null;
	}

	private void ApplyTags(List<RecruitTag> selectedTags, float kd, uint streak, float winRate, float headShot)
	{
	}

	private void ApplyStreakTag(uint streak)
	{
	}

	private void ApplyStatTag(int slotIndex, RecruitTag tag, float kd, float winRate, float headShot)
	{
	}

	private void OnJoinGroupBtnClick()
	{
	}

	private void OnGroupJoinNtf(object[] data)
	{
	}

	private void OnGroupJoinFail(object[] data)
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
