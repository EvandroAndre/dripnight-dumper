using GCommon;
using UnityEngine;

namespace COW;

public class CooperateEmoteData : CSVBaseData, IGetId
{
	public Vector3 MaleRootPosition;

	public Vector3 FemaleRootPosition;

	public ResourceID[] RandomMaleVFXS;

	public ResourceID[] RandomFemaleVFXS;

	public ResourceID PreviewMaleCooperateEmoteResID;

	public uint SetID;

	public ResourceID PreviewFemaleVFX;

	public ResourceID PreviewMaleVFX;

	public ResourceID PreviewFemaleCooperateEmoteIdleResID;

	public ResourceID PreviewFemaleCooperateEmoteResID;

	public float LobbyPositionParams;

	public ResourceID PreviewMaleCooperateEmoteIdleID;

	public uint ItemID;

	public bool IsLeader()
	{
		return false;
	}

	public bool NeedRandSeed()
	{
		return false;
	}

	public ResourceID GetRandomPreviewVFX(bool isFemale, uint seed = 0u)
	{
		return default(ResourceID);
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
