using UnityEngine;

namespace Cinemachine;

public abstract class CinemachineComponentBase : MonoBehaviour
{
	protected const float Epsilon = 0.0001f;

	private CinemachineVirtualCameraBase m_vcamOwner;

	private Transform mCachedFollowTarget;

	private CinemachineVirtualCameraBase mCachedFollowTargetVcam;

	private CinemachineTargetGroup mCachedFollowTargetGroup;

	private Transform mCachedLookAtTarget;

	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

	private CinemachineTargetGroup mCachedLookAtTargetGroup;

	public CinemachineVirtualCameraBase VirtualCamera => null;

	public Transform FollowTarget => null;

	public Transform LookAtTarget => null;

	public CinemachineTargetGroup FollowTargetGroup => null;

	public Vector3 FollowTargetPosition => default(Vector3);

	public Quaternion FollowTargetRotation => default(Quaternion);

	public CinemachineTargetGroup LookAtTargetGroup => null;

	public Vector3 LookAtTargetPosition => default(Vector3);

	public Quaternion LookAtTargetRotation => default(Quaternion);

	public CameraState VcamState => default(CameraState);

	public abstract bool IsValid { get; }

	public abstract CinemachineCore.Stage Stage { get; }

	private void UpdateFollowTargetCache()
	{
	}

	private void UpdateLookAtTargetCache()
	{
	}

	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
	{
	}

	public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
	{
		return false;
	}

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
	{
	}
}
