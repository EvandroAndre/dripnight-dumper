using GCommon;

namespace COW;

public class UGCCustomLevelObjectPackageConfigData : CSVBaseData
{
	public string PackageID;

	public ResourceID DescriptionRes;

	public ResourceID ManifestRes;

	public ResourceID DataRes;

	public ResourceID PackageRes;

	public ResourceID SettingRes;

	public override string GetPrimaryKey()
	{
		return null;
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
