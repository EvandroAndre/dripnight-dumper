using System;
using UnityEngine;

namespace Cinemachine;

public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
{
	[Serializable]
	public class Instruction
	{
		public CinemachineVirtualCameraBase m_VirtualCamera;

		public float m_Hold;

		public CinemachineBlendDefinition m_Blend;
	}

	public Transform m_LookAt;

	public Transform m_Follow;

	public bool m_ShowDebugText;

	public bool m_Loop;

	public CinemachineVirtualCameraBase[] m_ChildCameras;

	public Instruction[] m_Instructions;

	private ICinemachineCamera _003CLiveChild_003Ek__BackingField;

	private ICinemachineCamera _003CTransitioningFrom_003Ek__BackingField;

	private CameraState m_State;

	private float mActivationTime;

	private int mCurrentInstruction;

	private CinemachineBlend mActiveBlend;

	public override string Description => null;

	public ICinemachineCamera LiveChild
	{
		get
		{
			return _003CLiveChild_003Ek__BackingField;
		}
		set
		{
			_003CLiveChild_003Ek__BackingField = value;
		}
	}

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

	private ICinemachineCamera TransitioningFrom
	{
		get
		{
			return _003CTransitioningFrom_003Ek__BackingField;
		}
		set
		{
			_003CTransitioningFrom_003Ek__BackingField = value;
		}
	}

	public CinemachineVirtualCameraBase[] ChildCameras => null;

	public bool IsBlending => false;

	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
	{
		return false;
	}

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
	{
	}

	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
	{
	}

	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void OnGuiHandler()
	{
	}

	private void InvalidateListOfChildren()
	{
	}

	private void UpdateListOfChildren()
	{
	}

	public void ValidateInstructions()
	{
	}

	private void AdvanceCurrentInstruction(float deltaTime)
	{
	}
}
