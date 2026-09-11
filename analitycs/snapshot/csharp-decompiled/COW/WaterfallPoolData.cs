using System.Collections.Generic;
using proto;

namespace COW;

public class WaterfallPoolData
{
	public uint PoolType;

	public uint GenreID;

	public List<WaterfallValidData> ValidCodeList;

	public List<string> IndexList;

	public List<WorkshopCodeWithRankInfo> LeaderboardCodeList;

	public int LastIndex;

	public bool HasMore;

	public bool IsLoading;

	public int WaterfallExposureIndex;

	public string Strategy;

	public uint ConfigId;

	public string Title;

	public string Desc;
}
