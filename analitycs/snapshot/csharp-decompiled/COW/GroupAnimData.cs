using GCommon;
using UnityEngine;

namespace COW;

public class GroupAnimData : CSVBaseData
{
	public uint iID;

	public uint sortId;

	public ResourceID AnimationResIDMale;

	public ResourceID ArriveAnimMaleIdle;

	public ResourceID AnimationResIDFemale;

	public ResourceID ArriveAnimFemaleIdle;

	public ResourceID CameraAnimationResIDMale;

	public ResourceID CameraAnimationResIDFemale;

	public ResourceID VFXMaleIngame;

	public ResourceID VFXMaleSystem;

	public ResourceID VFXFemaleIngame;

	public ResourceID VFXFemaleSystem;

	public ResourceID SFXResourceId;

	public ESourceType sourceTypeKey;

	public float AnimDuration;

	public bool IsConfigAnimationRotation2;

	public bool IsConfigAnimationRotation3;

	public bool IsConfigAnimationRotation4;

	public Vector3 AnimationRotation2;

	public Vector3 AnimationRotation3;

	public Vector3 AnimationRotation4;

	public bool HideMvpBG;

	public bool GroupAnimBGTag;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool TryGetAnimationRotationByPosId(int posId, out Vector3 v3)
	{
		v3 = default(Vector3);
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
