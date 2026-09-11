using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class WorkShopPrefabResourceContentConfigData : CSVBaseData
{
	public uint PrefabID;

	public uint OptionID;

	public uint PrefabSortID;

	public bool IsNew;

	public EUGCAssetProviderType Type;

	public List<ModeTemplate> MustMode;

	public uint MustModeSortID;

	public List<ModeTemplate> ForbiddenMode;

	public List<int> ForbiddenTemplateIDs;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	protected List<ModeTemplate> GetModeTemplateFromConfig(string modeString)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
