using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UITwentySixSeasonYearHeroicPointController : UISeasonYearHeroicPointController
{
	protected override uint GetSeasonYearId()
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override PeakRankData GetHistoryPeakRankData(DLBMPCCFKKM rankType = DLBMPCCFKKM.EMATCHMODE_RANKING, PlayerHistorySeasonRankInfo rankInfo = null)
	{
		return null;
	}

	public void AdjustTipsTrans(Transform otherTips, Vector3 copyTrans)
	{
	}

	public Vector3 GetTipsLocPos()
	{
		return default(Vector3);
	}

	protected override void SetSeasonStateBySeasonId(SeasonYearRankType rankType, uint seasonId, uint index)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetSeasonYearId()
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public PeakRankData _003C_003EiFixBaseProxy_GetHistoryPeakRankData(DLBMPCCFKKM P0, PlayerHistorySeasonRankInfo P1)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetSeasonStateBySeasonId(SeasonYearRankType P0, uint P1, uint P2)
	{
	}
}
