using GCommon;

namespace COW;

public class NationFlagData : CSVBaseData
{
	public string countryOrArea;

	public string region;

	public string key;

	public string icon;

	public bool switchFlag;

	public bool isOpen;

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
