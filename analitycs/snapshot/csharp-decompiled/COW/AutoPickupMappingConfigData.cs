using GCommon;

namespace COW;

public class AutoPickupMappingConfigData : CSVBaseData
{
	public int TypeID;

	public uint[] GameMode;

	public string TypeTitleKey;

	public int[] AutoPickUpSettingItem;

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
