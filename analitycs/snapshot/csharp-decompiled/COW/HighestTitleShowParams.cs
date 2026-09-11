using proto;

namespace COW;

public class HighestTitleShowParams
{
	public bool isBR;

	public uint Rank;

	public HighestTitleType type;

	public long TimeStamp;

	public uint title_cfg_id;

	public string weaponName;

	public string RegionName;

	public HighestTitleShowParams()
	{
	}

	public HighestTitleShowParams(WeaponPowerTitleRecordInfo info)
	{
	}

	public HighestTitleShowParams(CSPeakTitleRecordInfo info)
	{
	}

	public HighestTitleShowParams(RankingTitleRecordInfo info)
	{
	}
}
