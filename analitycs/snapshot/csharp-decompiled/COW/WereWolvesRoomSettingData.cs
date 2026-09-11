using GCommon;

namespace COW;

public class WereWolvesRoomSettingData : CSVBaseData
{
	public int TypeID;

	public string LocKey;

	public uint DefaultValue;

	public uint MinValue;

	public uint MaxValue;

	public uint StepValue;

	public uint[] OptionValues;

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
