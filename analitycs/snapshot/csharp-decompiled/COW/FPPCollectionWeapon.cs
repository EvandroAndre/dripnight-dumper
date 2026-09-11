using GCommon;
using UnityEngine;

namespace COW;

public class FPPCollectionWeapon : CSVBaseData, IGetId
{
	public Vector3 WeaponBindPosOffset;

	public Vector3 FPPBulletRotate;

	public Vector3 FPPBulletPos;

	public Vector3 WeaponBindRotateOffset;

	public Vector3 WeaponBindScale;

	public Vector3 IKTargetRightRotate;

	public Vector3 IKTargetPos;

	public Vector3 IKTargetRotate;

	public Vector3 IKTargetRightPos;

	public Vector3 MuzzleOffset;

	public uint ItemID;

	public ResourceID FPPInGameResID;

	public bool IKSwitch;

	public bool IKSwitchRight;

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
