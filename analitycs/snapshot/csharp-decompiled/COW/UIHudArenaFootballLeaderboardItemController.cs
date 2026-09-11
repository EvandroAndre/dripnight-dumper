using GCommon;

namespace COW;

internal class UIHudArenaFootballLeaderboardItemController : UIHUDTeamBattleScoreBoardItemController
{
	private LeaderboardData m_Data;

	public LeaderboardData DataInfo => null;

	protected override void OnUIInit()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnFootballScoreChange(int goal)
	{
	}

	protected override void OnFootballAssistChange(int assist)
	{
	}

	private void PlayerSkillChanged(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFootballScoreChange(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFootballAssistChange(int P0)
	{
	}
}
