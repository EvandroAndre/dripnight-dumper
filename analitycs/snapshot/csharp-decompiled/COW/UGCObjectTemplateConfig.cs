using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCObjectTemplateConfig : CSVBaseData
{
	public List<ModeTemplate> MustMode;

	public List<ModeTemplate> ForbiddenMode;

	public List<int> ForbiddenTemplateIDs;

	public string MustModeString;

	public string ForbiddenModeString;

	public string ForbiddenTemplateID;

	public uint PrefabID;

	public ResourceID ObjectTemplateRes;

	public uint PrefabSortID;

	public uint OptionID;

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
