using GCommon;
using UnityEngine;

namespace COW;

public class FPPWeaponDebugData : CSVBaseData, IGetId
{
	public Vector3 WeaponBindPosOffset1;

	public Vector3 WeaponBindScale3;

	public Vector3 WeaponBindPosOffset2;

	public Vector3 WeaponBindPosOffset3;

	public Vector3 WeaponBindScale2;

	public Vector3 WeaponBindRotateOffset2;

	public Vector3 WeaponBindRotateOffset3;

	public Vector3 WeaponBindScale1;

	public Vector3 WeaponBindRotateOffset1;

	public uint Id;

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
