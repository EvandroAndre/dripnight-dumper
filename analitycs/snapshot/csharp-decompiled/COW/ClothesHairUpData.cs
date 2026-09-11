using GCommon;

namespace COW;

public class ClothesHairUpData : CSVBaseData, IGetId
{
	public uint iID;

	public uint LV0;

	public uint LV1;

	public uint LV2;

	public uint LV3;

	public uint GetId()
	{
		return 0u;
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
