using GCommon;
using UnityEngine;

namespace COW;

public class SkyboardData : CSVBaseData, IGetId
{
	public static bool LocIdxSerialized;

	public uint nameId;

	public Vector3 HDLobbyPreviewPosition;

	public Vector3 HDLobbyPreviewScale;

	public Vector3 HDLobbyPreviewAngle;

	public Vector3 HDLobbyInGamePosition;

	public Vector3 HDLobbyInGameScale;

	public Vector3 HDLobbyInGameAngle;

	public ESourceType sourceTypeKey;

	public float skySurfingSpeedDelta;

	public float skySurfingMaxHSpeed;

	public float skySurfingMinHSpeed;

	public ResourceID previewRes;

	public float skySurfingMinVSpeed;

	public float skyDivingSpeedDelta;

	public float skyDivingMaxHSpeed;

	public float skyDivingMinHSpeed;

	public float skyDivingMaxVSpeed;

	public float skyDivingMinVSpeed;

	public float swimSurfingSpeed;

	public uint sortId;

	public ResourceID inGameRes;

	public uint NewMatType;

	public uint iID;

	public float skySurfingMaxVSpeed;

	public bool MAXShow;

	public bool IsWithEffect;

	public bool showHoverboardComponent;

	public string name => null;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
