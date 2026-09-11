using COW.GamePlay;
using COW.Gameplay.MultiplayerGame;
using GCommon;

namespace COW;

internal abstract class UIHUDUGC_BaseLeaderboardController : UIHUDUGC_InternalHudController
{
	protected UGCScoreBlackboard m_ScoreBlackboard;

	protected UserControlHandler m_UserControl;

	protected bool m_OriginInputState;

	protected uint m_SelfTeamIndex;

	private float m_LastUpateTime;

	protected override void OnUIInit()
	{
	}

	protected abstract void InitView();

	protected abstract UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player);

	protected abstract UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(BHGGAEEHJCO playerId);

	protected abstract UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex);

	protected virtual void InitViewData()
	{
	}

	protected virtual void UpdateAllTeammateItemInfo()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	protected UIHUDUGC_BaseLeaderboard_TeammateItemController AddTeammateItem(Player player)
	{
		return null;
	}

	protected bool IsSelfTeamIndex(uint teamIndex)
	{
		return false;
	}

	protected int ConvertToPlayerID(object player)
	{
		return 0;
	}

	private void OnAddPlayer(GEvent param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
