using GCommon;
using UnityEngine;

namespace COW;

public class ChestChangeSkinData : CSVBaseData, IGetId
{
	public Vector3 OneButtonPosOffset;

	public Vector3 MultiButtonPosOffset;

	public Vector3 OneDiscountPosOffset;

	public Vector3 MultiDiscountPosOffset;

	public string LobbyEntranceAnimClip;

	public ResourceID BackgroundVFX;

	public uint DiscountVFXType;

	public ResourceID TTVFX;

	public ResourceID TokenWheelPoolBGVFX;

	public ResourceID TitleVFX;

	public uint ChangeSkinType;

	public ResourceID MultiButtonVFX;

	public ResourceID LobbyEntranceVFX;

	public ResourceID OneButtonVFX;

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
