using GCommon;

namespace COW;

public class ClanLuckyBagConfigData : CSVBaseData
{
	public const string PRIMARYKEY = "key";

	public uint EffectiveHours;

	public uint MaxDrawNumPerDay;

	public uint MaxBagsPerClan;

	public uint GuildTokenItemID;

	public uint FreezeHours;

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
