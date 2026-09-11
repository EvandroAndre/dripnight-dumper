using System.Collections.Generic;
using GCommon;

namespace COW;

public class BarrageConfigData : CSVBaseData, IGetId
{
	public uint BarrageType;

	public Dictionary<uint, BarrageSingleConfig> BarrageOneRowConfigs;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
