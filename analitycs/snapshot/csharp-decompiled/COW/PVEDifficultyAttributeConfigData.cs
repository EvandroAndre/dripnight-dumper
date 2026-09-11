using GCommon;

namespace COW;

public class PVEDifficultyAttributeConfigData : CSVBaseData
{
	public uint AttrId;

	public uint AttrGroup;

	public string Name;

	private string m_DescKey;

	private string[] m_DescKeyParams;

	public string LocDesc => null;

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
