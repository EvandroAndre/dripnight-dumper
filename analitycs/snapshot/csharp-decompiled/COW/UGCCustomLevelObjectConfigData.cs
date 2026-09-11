using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCCustomLevelObjectConfigData : CSVBaseData
{
	public string PackageID;

	public List<ModeTemplate> MustMode;

	public List<ModeTemplate> ForbiddenMode;

	public List<int> ForbiddenTemplateIDs;

	public string ForbiddenTemplateID;

	public string ForbiddenModeString;

	public string IconUrl;

	public string MustModeString;

	public string PrefabUUID;

	public string Name;

	public uint OptionID;

	public uint PrefabID;

	public ResourceID IconRes;

	public uint PrefabSortID;

	public uint MustModeSortID;

	public bool IsNew;

	public override void PostDeserializeData()
	{
	}

	private List<ModeTemplate> GetModeTemplateFromConfig(string modeString)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
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
