using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCModeTemplateResConfigData : CSVBaseData
{
	public int ID;

	public List<ResourceID> ResourceIds;

	public List<uint> NeedItemIds;

	public List<List<uint>> NeedOneOfItemIds;

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
