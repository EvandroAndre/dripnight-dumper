using GCommon;

namespace COW;

public class FateRandomSubModeData : CSVBaseData
{
	public uint Id;

	public string IconName;

	public string ModeName;

	public string[] DescStrings;

	private string m_desc;

	public string GetDesc()
	{
		return null;
	}

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
