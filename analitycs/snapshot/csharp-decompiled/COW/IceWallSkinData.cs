using GCommon;
using UnityEngine;

namespace COW;

public class IceWallSkinData : CSVBaseData
{
	public uint skinid;

	public ResourceID inGameRes;

	public ResourceID previewgameRes;

	public Vector3 HDLobbyPosition;

	public Vector3 HDLobbyScale;

	public Vector3 HDLobbyAngle;

	public Vector3 HDLobbyPreviewPosition;

	public Vector3 HDLobbyPreviewScale;

	public Vector3 HDLobbyPreviewAngle;

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
