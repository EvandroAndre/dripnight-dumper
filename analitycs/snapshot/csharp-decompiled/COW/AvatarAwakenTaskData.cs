using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarAwakenTaskData : CSVBaseData
{
	public uint IID;

	public uint AvatarId;

	public uint TaskType;

	public uint TaskNeedValue;

	public string TaskDesc;

	public bool NeedChangeValType;

	public uint RewardType1;

	public uint RewardId1;

	public uint RewardCnt1;

	public uint RewardType2;

	public uint RewardId2;

	public uint RewardCnt2;

	public uint RewardType3;

	public uint RewardId3;

	public uint RewardCnt3;

	public string ComicCDNLink;

	public string ComicDesc;

	public string ComicLockCDN;

	public string ComicUnLockCDN;

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
