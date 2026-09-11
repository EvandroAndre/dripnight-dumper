using System;
using UnityEngine;

[Serializable]
public class ANGLELIMIT_PROPERTY
{
	public string BaseAxis_1;

	public string BaseAxis_1_Parent;

	public Quaternion BaseAxis_1_quaternion;

	public string BaseAxis_2;

	public string BaseAxis_2_Parent;

	public Quaternion BaseAxis_2_quaternion;

	public float BaseAxisTwoSettingsRate;

	public float BoneBlendRate;

	public bool PivotLimitUseFlag;

	public float PivotLimitRotOffset;

	public bool DBG_PivotLimitDispFlag;

	public float Y_AngleMin;

	public float Y_AngleMax;

	public float Z_AngleMin;

	public float Z_AngleMax;
}
