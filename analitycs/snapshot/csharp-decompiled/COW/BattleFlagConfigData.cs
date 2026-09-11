using GCommon;
using UnityEngine;

namespace COW;

public class BattleFlagConfigData : CSVBaseData, IGetId
{
	public uint iID;

	public uint LinkID;

	public ResourceID resLobbyModel;

	public ResourceID resModel;

	public ResourceID EffectRes;

	public uint HandPoint;

	public uint InfoMessage;

	public Vector3 InfoRevision;

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

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
