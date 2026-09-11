using GCommon;

namespace COW;

public class PartyBeatEffectData : CSVBaseData
{
	public uint EffectLevel;

	public uint NeedCombo;

	public ResourceID EffectResID;

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
