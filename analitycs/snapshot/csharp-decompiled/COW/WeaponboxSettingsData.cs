using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class WeaponboxSettingsData : CSVBaseData, IGetId
{
	public uint item_id;

	public bool adjusttag;

	public string adjustment;

	private List<Vector2Int> ParseAdjustmentString(string strAdjustment)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
