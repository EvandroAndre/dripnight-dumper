using GCommon;

namespace COW;

public class BannerData : CSVBaseData, IGetId
{
	public string baseResName;

	public ResourceID effectRes;

	public uint sortId;

	public uint iID;

	public int IntSourceType;

	public bool NotInCDN;

	public ResourceID baseRes;

	public static bool LocIdxSerialized;

	public uint nameId;

	public string name => null;

	public ESourceType sourceTypeKey => ESourceType.ALL;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override void PostDeserializeData()
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}
}
