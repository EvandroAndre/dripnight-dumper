using GCommon;

namespace COW;

public class NBGP2BigItemsConfig : CSVBaseData, IGetId
{
	public uint BigItemType;

	public ResourceID AcquiredBannerIconStart;

	public ResourceID AcquiredBannerIconEnd;

	public ResourceID AcquiredBannerVFX;

	public ResourceID AcquiredBannerSFX;

	public string AcquiredBannerTitle;

	public string AcquiredBannerDesc;

	public string IngameModelRes;

	public string MapIconRes;

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
}
