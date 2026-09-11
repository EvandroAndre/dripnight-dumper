using GCommon;

namespace COW;

public class WorkshopPremiumDebug : CSVBaseData, IGetId
{
	public uint store_id;

	public string name;

	public uint item_id;

	public uint gems_price;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
