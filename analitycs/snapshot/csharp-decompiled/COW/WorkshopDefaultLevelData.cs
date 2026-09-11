using GCommon;
using UnityEngine;

namespace COW;

public class WorkshopDefaultLevelData : CSVBaseData
{
	public uint ID;

	public uint MapID;

	public uint ResID;

	public Vector3 Position;

	public uint Direction;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
