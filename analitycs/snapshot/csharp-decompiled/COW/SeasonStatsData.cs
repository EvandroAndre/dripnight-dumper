using message;

namespace COW;

public class SeasonStatsData
{
	public int index;

	public uint season_id;

	public bool is_current_season;

	public DLBMPCCFKKM matchMode;

	public bool is_arrow_open;

	public SeasonStatsData(int i, uint seasonId, bool iscurrentSeason, DLBMPCCFKKM mode, bool isOpen = false)
	{
	}
}
