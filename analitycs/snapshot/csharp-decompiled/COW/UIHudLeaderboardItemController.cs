using GCommon;

namespace COW;

internal class UIHudLeaderboardItemController : UIBaseController
{
	private UIHudLeaderboardItemView m_View;

	private LeaderboardData m_DataInfo;

	private UIPrivilegeIconController m_PrivilegeIconController;

	public LeaderboardData DataInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetRankInfo(int rankLevel, int peakRankPos)
	{
	}

	public void SetRole(BadgeInfoInGame badgeInfoInGame)
	{
	}

	private void UpdateHeadIcon()
	{
	}

	public void SetDataInfo(LeaderboardData dataInfo)
	{
	}

	private void SetBackground(bool isLocalPlayer)
	{
	}

	public void SetKillCount(int k)
	{
	}

	public void SetDeadCount(int d)
	{
	}

	public void SetAssistCount(int a)
	{
	}

	public void SetTotalDamage(int dmg)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
