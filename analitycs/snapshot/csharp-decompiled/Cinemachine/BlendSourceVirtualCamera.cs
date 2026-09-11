using UnityEngine;

namespace Cinemachine;

public class BlendSourceVirtualCamera : ICinemachineCamera
{
	private CinemachineBlend _003CBlend_003Ek__BackingField;

	private int _003CPriority_003Ek__BackingField;

	private Transform _003CLookAt_003Ek__BackingField;

	private Transform _003CFollow_003Ek__BackingField;

	private CameraState _003CState_003Ek__BackingField;

	public CinemachineBlend Blend
	{
		get
		{
			return _003CBlend_003Ek__BackingField;
		}
		set
		{
			_003CBlend_003Ek__BackingField = value;
		}
	}

	public string Name => null;

	public string Description => null;

	public int Priority
	{
		get
		{
			return _003CPriority_003Ek__BackingField;
		}
		set
		{
			_003CPriority_003Ek__BackingField = value;
		}
	}

	public Transform LookAt
	{
		get
		{
			return _003CLookAt_003Ek__BackingField;
		}
		set
		{
			_003CLookAt_003Ek__BackingField = value;
		}
	}

	public Transform Follow
	{
		get
		{
			return _003CFollow_003Ek__BackingField;
		}
		set
		{
			_003CFollow_003Ek__BackingField = value;
		}
	}

	public CameraState State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		private set
		{
			_003CState_003Ek__BackingField = value;
		}
	}

	public GameObject VirtualCameraGameObject => null;

	public bool IsValid => false;

	public ICinemachineCamera ParentCamera => null;

	public BlendSourceVirtualCamera(CinemachineBlend blend)
	{
	}

	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
	{
		return false;
	}

	public void UpdateCameraState(Vector3 worldUp, float deltaTime)
	{
	}

	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
	{
	}

	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
	{
	}

	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
	{
	}
}
