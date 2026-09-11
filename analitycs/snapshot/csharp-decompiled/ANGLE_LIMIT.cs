using System;
using UnityEngine;

[Serializable]
public class ANGLE_LIMIT
{
	public Transform BaseAxis_1;

	public Transform BaseAxis_2;

	public float BaseAxisTwoSettingsRate;

	public float BoneBlendRate;

	public bool PivotLimitUseFlag;

	public float PivotLimitRotOffset;

	public bool DBG_PivotLimitDispFlag;

	public float Y_AngleMin;

	public float Y_AngleMax;

	public float Z_AngleMin;

	public float Z_AngleMax;

	public HangManager.LANGUAGE_TYPE LanguageType;
}
