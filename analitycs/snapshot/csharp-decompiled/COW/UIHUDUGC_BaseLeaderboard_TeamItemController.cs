using System;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal abstract class UIHUDUGC_BaseLeaderboard_TeamItemController : UIBaseController
{
	protected int m_TeamIndex;

	public int TeamIndex => 0;

	public abstract UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player);

	public abstract void DestroyAllTeammateItems(Action<BHGGAEEHJCO> action);

	public void SetTeamIndex(int teamIndex)
	{
	}

	protected string GetInfoTitle(HPGAEEBKCIE infoType)
	{
		return null;
	}
}
