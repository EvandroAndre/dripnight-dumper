using GCommon;

namespace COW;

public class RoomCreateCSEcoData : CSVBaseData
{
	public uint Index;

	public string Key;

	public int Min;

	public int Max;

	public int Default;

	public int Step;

	public bool IsOpen;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
