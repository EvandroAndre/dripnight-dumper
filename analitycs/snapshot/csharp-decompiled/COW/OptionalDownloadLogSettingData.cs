using GCommon;

namespace COW;

public class OptionalDownloadLogSettingData : CSVBaseData
{
	public uint ID;

	public EResconfOptionalAbDataType Type;

	public string Content;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private EResconfOptionalAbDataType ReadResconfOptionalAbDataType(string fieldName, string[] headers, string[] values, int defaultValue = 0)
	{
		return EResconfOptionalAbDataType.None;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
