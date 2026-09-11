using GCommon;

namespace COW;

public class NewPlayerLevelUpLimitTimeData : CSVBaseData
{
	public string DateOB52;

	public uint LevelUpperLimit;

	public uint NewPlayerDays;

	public uint StoreLevel;

	public uint NewBieOfferDays;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public ulong GetDateOB52Timestamp()
	{
		return 0uL;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
