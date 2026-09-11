using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine;

public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
{
	public enum StandbyUpdateMode
	{
		Never,
		Always,
		RoundRobin
	}

	public enum BlendHint
	{
		None,
		SphericalPosition,
		CylindricalPosition,
		ScreenSpaceAimWhenTargetsDiffer
	}

	[Serializable]
	public struct TransitionParams
	{
		public BlendHint m_BlendHint;

		public bool m_InheritPosition;

		public CinemachineBrain.VcamActivatedEvent m_OnCameraLive;
	}

	public string[] m_ExcludedPropertiesInInspector;

	public int[] m_LockStageInInspector;

	private int m_ValidatingStreamVersion;

	private bool m_OnValidateCalled;

	private int m_StreamingVersion;

	public int m_Priority;

	public StandbyUpdateMode m_StandbyUpdate;

	private List<CinemachineExtension> mExtensions;

	private bool m_previousStateIsValid;

	private Transform m_previousLookAtTarget;

	private Transform m_previousFollowTarget;

	private bool mSlaveStatusUpdated;

	private CinemachineVirtualCameraBase m_parentVcam;

	private int m_QueuePriority;

	public int ValidatingStreamVersion
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public string Name => null;

	public virtual string Description => null;

	public int Priority
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public GameObject VirtualCameraGameObject => null;

	public bool IsValid => false;

	public abstract CameraState State { get; }

	public ICinemachineCamera ParentCamera => null;

	public abstract Transform LookAt { get; set; }

	public abstract Transform Follow { get; set; }

	public bool PreviousStateIsValid
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void AddExtension(CinemachineExtension extension)
	{
	}

	public virtual void RemoveExtension(CinemachineExtension extension)
	{
	}

	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime)
	{
	}

	protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint)
	{
	}

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
	{
		return false;
	}

	public void UpdateCameraState(Vector3 worldUp, float deltaTime)
	{
	}

	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnValidate()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Update()
	{
	}

	private void UpdateSlaveStatus()
	{
	}

	protected Transform ResolveLookAt(Transform localLookAt)
	{
		return null;
	}

	protected Transform ResolveFollow(Transform localFollow)
	{
		return null;
	}

	private void UpdateVcamPoolStatus()
	{
	}

	public void MoveToTopOfPrioritySubqueue()
	{
	}

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
	{
	}

	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend)
	{
		return null;
	}

	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens)
	{
		return default(CameraState);
	}
}
