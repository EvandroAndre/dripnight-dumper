using System.Collections.Generic;
using GCommon;

namespace COW;

public class WorkShopLevelExp : CSVBaseData
{
	public uint Level;

	public uint Exp;

	public string Name;

	public string Icon;

	public uint MaxCost;

	public string explain;

	public uint RewardType1;

	public uint RewardId1;

	public uint RewardCnt1;

	public uint RewardType2;

	public uint RewardId2;

	public uint RewardCnt2;

	public uint RewardType3;

	public uint RewardId3;

	public uint RewardCnt3;

	public uint Subscriptions;

	public uint FollowLimit;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public List<BaseItemInfo> GetAwardList()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
