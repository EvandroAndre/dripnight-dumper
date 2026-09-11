using GCommon;
using message;
using proto;

namespace COW;

public class UITwentyFiveSeasonYearHeroicPointController : UISeasonYearHeroicPointController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override uint GetSeasonYearId()
	{
		return 0u;
	}

	protected override PeakRankData GetHistoryPeakRankData(DLBMPCCFKKM rankType = DLBMPCCFKKM.EMATCHMODE_RANKING, PlayerHistorySeasonRankInfo rankInfo = null)
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetSeasonYearId()
	{
		return 0u;
	}

	public PeakRankData _003C_003EiFixBaseProxy_GetHistoryPeakRankData(DLBMPCCFKKM P0, PlayerHistorySeasonRankInfo P1)
	{
		return null;
	}
}
