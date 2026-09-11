using GCommon;

namespace COW;

public class LevelEntranceData : CSVBaseData
{
	public uint EntranceId;

	public string EntranceNameKey;

	public uint LockStatus;

	public uint UnlockType;

	public uint UnlockNum;

	public uint AnnounceLevel;

	public string IconResId;

	public string IconShow;

	public uint UnlockNumGuest;

	public string DetailTips;

	public bool ExcludeVeteran;

	public bool IsShowInNewBieCorner;

	public uint AnnounceSort;

	public bool IsShowInAnnounce;

	public uint[] GoposV2;

	public uint[] GoposV1;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
