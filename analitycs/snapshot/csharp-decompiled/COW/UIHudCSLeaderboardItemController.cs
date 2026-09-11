using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudCSLeaderboardItemController : UIHUDTeamBattleScoreBoardItemController
{
	private LeaderboardData m_Data;

	private float m_ScrollSize;

	public LeaderboardData DataInfo => null;

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public void RepositionPanelSkillRoot()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnInitData(Player player)
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnKillChange(int kill)
	{
	}

	protected override void OnDeadChange(int dead)
	{
	}

	protected override void OnDamageChange(uint damage)
	{
	}

	public void SetRankInfo(int rankLevel, int peakRankPos, int rankPoint)
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void SetWinStreak(uint winStreak)
	{
	}

	private void RefreshRankIcon(ResourceID resId)
	{
	}

	public bool BothShowRankAndWinStreak()
	{
		return false;
	}

	public void StreakScroll(int winStreakScrollIndex)
	{
	}

	private void ScrollFinish()
	{
	}

	private void ResetScrollView()
	{
	}

	public void ResetScrollItemPos()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitData(Player P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnKillChange(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDeadChange(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDamageChange(uint P0)
	{
	}
}
