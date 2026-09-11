using GCommon;
using proto;

namespace COW;

public class UISeasonReplayOverviewHighlightController : UIBaseController
{
	private UISeasonReplayOverviewHighlightView m_View;

	private UIModelSeasonReplay m_ModelReplay;

	private uint m_SeasonID;

	private bool m_IsBR;

	private RankingSeasonReplayEvent m_Data;

	private const string BRPeakRankIcon = "FF_UI_SeasonReplay_Medal_7_1";

	private const string CSPeakRankIcon = "FF_UI_SeasonReplay_Medal_CS";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowHighlightDetail(RankingSeasonReplayEvent data, uint seasonID, bool isBR)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
