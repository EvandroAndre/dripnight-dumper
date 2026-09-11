using System;
using UnityEngine;

namespace Cinemachine;

public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
{
	public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom);

	public delegate void DestroyPipelineDelegate(GameObject pipeline);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CinemachineComponentBase> _003C_003E9__39_0;

		internal int _003CUpdateComponentPipeline_003Eb__39_0(CinemachineComponentBase c1, CinemachineComponentBase c2)
		{
			return 0;
		}
	}

	public Transform m_LookAt;

	public Transform m_Follow;

	public LensSettings m_Lens;

	public TransitionParams m_Transitions;

	private BlendHint m_LegacyBlendHint;

	public const string PipelineName = "cm";

	public static CreatePipelineDelegate CreatePipelineOverride;

	public static DestroyPipelineDelegate DestroyPipelineOverride;

	private bool _003CUserIsDragging_003Ek__BackingField;

	private CameraState m_State;

	private CinemachineComponentBase[] m_ComponentPipeline;

	private Transform m_ComponentOwner;

	private Transform mCachedLookAtTarget;

	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

	public override CameraState State => default(CameraState);

	public override Transform LookAt
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Transform Follow
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool UserIsDragging
	{
		get
		{
			return _003CUserIsDragging_003Ek__BackingField;
		}
		set
		{
			_003CUserIsDragging_003Ek__BackingField = value;
		}
	}

	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnValidate()
	{
	}

	private void OnTransformChildrenChanged()
	{
	}

	private void Reset()
	{
	}

	private void DestroyPipeline()
	{
	}

	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom)
	{
		return null;
	}

	public void InvalidateComponentPipeline()
	{
	}

	public Transform GetComponentOwner()
	{
		return null;
	}

	public CinemachineComponentBase[] GetComponentPipeline()
	{
		return null;
	}

	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage)
	{
		return null;
	}

	public T GetCinemachineComponent<T>() where T : CinemachineComponentBase
	{
		return null;
	}

	public T AddCinemachineComponent<T>() where T : CinemachineComponentBase
	{
		return null;
	}

	private void UpdateComponentPipeline()
	{
	}

	public static void SetFlagsForHiddenChild(GameObject child)
	{
	}

	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
	{
		return default(CameraState);
	}

	private CinemachineCore.Stage AdvancePipelineStage(ref CameraState state, float deltaTime, CinemachineCore.Stage curStage, int maxStage, bool hasAim)
	{
		return CinemachineCore.Stage.Body;
	}

	public void SetStateRawPosition(Vector3 pos)
	{
	}

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
	{
	}

	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
	{
	}
}
