using System;

namespace COW;

[Serializable]
public class ActiveSkillJsonData
{
	public string CastAnimMaleResID;

	public string CastAnimFemaleResID;

	public bool LockAnim;

	public bool LockInput;

	public bool FreezeMove;

	public bool LockCamera;

	public bool LockFire;

	public bool IsCastCameraAnim;

	public float CameraBackOff;

	public float CameraUpOff;

	public float CameraBackTime;

	public float CameraHoldTime;

	public float CameraReturnTime;

	public string CastCameraAnimResID;

	public float CastCameraAnimTime;

	public float AreaIndicatorXAngle;

	public bool EnableTeammateAfterimage;

	public bool EnableFirstPhaseAfterimage;

	public bool EnableThirdPhaseAfterimage;

	public float AfterimageLifeTime;

	public CityHeroBoyConfig CityHeroBoyConfig;
}
