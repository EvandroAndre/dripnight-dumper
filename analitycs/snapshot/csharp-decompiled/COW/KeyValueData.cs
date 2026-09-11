using GCommon;

namespace COW;

public class KeyValueData : CSVBaseData
{
	public string Name;

	public object Value;

	public static string[] Header;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	protected void ParseValue(string varType, string varValueStr, out object varValue)
	{
		varValue = null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
