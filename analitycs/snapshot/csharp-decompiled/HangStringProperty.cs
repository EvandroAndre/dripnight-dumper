using System.Collections.Generic;
using UnityEngine;

public class HangStringProperty : ScriptableObject
{
	public int CalcPriorityId;

	public string StringFirstBonTrans;

	public float Hardness;

	public AnimationCurve HardnessCurve;

	public float AirResistance;

	public AnimationCurve AirResistanceCurve;

	public float StringRad;

	public AnimationCurve StringRadCurve;

	public float StringGravity;

	public List<float> NodeGravity;

	public List<string> ExcludeTrans;

	public HangString.FREEZE_AXIS FreezeAxis;

	public float FarClipCalcDist;

	public List<HangColliderSphereProperty> HangCollider_SphereList;

	public List<HangColliderCapsuleProperty> HangCollider_CapsuleList;

	public List<HangColliderPlaneProperty> HangCollider_PlaneList;

	public bool DBG_AngleLimitDisp;

	public List<ANGLELIMIT_PROPERTY> AngleLimit;

	public float FirstBoneRotZOffset;

	public List<float> NodeWindForcePercentage;

	public HangString.StringType StringSetting;
}
