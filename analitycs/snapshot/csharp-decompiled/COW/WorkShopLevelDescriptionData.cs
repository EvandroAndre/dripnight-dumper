using GCommon;

namespace COW;

public class WorkShopLevelDescriptionData : CSVBaseData
{
	public uint ID;

	public uint GameMode;

	public uint Template;

	public string TagText;

	public string ImageUrl;

	public ResourceID SettingDataResId;

	public ResourceID VariableDataResId;

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
