using UnityEngine;

namespace Cinemachine;

public class CinemachineBlend
{
	private ICinemachineCamera _003CCamA_003Ek__BackingField;

	private ICinemachineCamera _003CCamB_003Ek__BackingField;

	private AnimationCurve _003CBlendCurve_003Ek__BackingField;

	private float _003CTimeInBlend_003Ek__BackingField;

	private float _003CDuration_003Ek__BackingField;

	public ICinemachineCamera CamA
	{
		get
		{
			return _003CCamA_003Ek__BackingField;
		}
		set
		{
			_003CCamA_003Ek__BackingField = value;
		}
	}

	public ICinemachineCamera CamB
	{
		get
		{
			return _003CCamB_003Ek__BackingField;
		}
		set
		{
			_003CCamB_003Ek__BackingField = value;
		}
	}

	public AnimationCurve BlendCurve
	{
		get
		{
			return _003CBlendCurve_003Ek__BackingField;
		}
		set
		{
			_003CBlendCurve_003Ek__BackingField = value;
		}
	}

	public float TimeInBlend
	{
		get
		{
			return _003CTimeInBlend_003Ek__BackingField;
		}
		set
		{
			_003CTimeInBlend_003Ek__BackingField = value;
		}
	}

	public float BlendWeight => 0f;

	public bool IsValid => false;

	public float Duration
	{
		get
		{
			return _003CDuration_003Ek__BackingField;
		}
		set
		{
			_003CDuration_003Ek__BackingField = value;
		}
	}

	public bool IsComplete => false;

	public string Description => null;

	public CameraState State => default(CameraState);

	public bool Uses(ICinemachineCamera cam)
	{
		return false;
	}

	public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t)
	{
	}

	public void UpdateCameraState(Vector3 worldUp, float deltaTime)
	{
	}
}
