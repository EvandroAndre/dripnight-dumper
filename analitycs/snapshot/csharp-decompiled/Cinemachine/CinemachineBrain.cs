using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Cinemachine;

public class CinemachineBrain : MonoBehaviour
{
	public enum UpdateMethod
	{
		FixedUpdate,
		LateUpdate,
		SmartUpdate
	}

	[Serializable]
	public class BrainEvent : UnityEvent<CinemachineBrain>
	{
	}

	[Serializable]
	public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
	{
	}

	private class BrainFrame
	{
		public int id;

		public CinemachineBlend blend;

		public CinemachineBlend workingBlend;

		public BlendSourceVirtualCamera workingBlendSource;

		public float deltaTimeOverride;

		public float timeOfOverride;

		public bool Active => false;

		public bool TimeOverrideExpired => false;
	}

	private sealed class _003CAfterPhysics_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CinemachineBrain _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAfterPhysics_003Ed__30(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public bool m_ShowDebugText;

	public bool m_ShowCameraFrustum;

	public bool m_IgnoreTimeScale;

	public bool m_FixFovToScreen;

	public Transform m_WorldUpOverride;

	public UpdateMethod m_UpdateMethod;

	public CinemachineBlendDefinition m_DefaultBlend;

	public CinemachineBlenderSettings m_CustomBlends;

	private Camera m_OutputCamera;

	private float m_OutputCameraVirtualFov;

	public BrainEvent m_CameraCutEvent;

	public VcamActivatedEvent m_CameraActivatedEvent;

	private static ICinemachineCamera mSoloCamera;

	private Coroutine mPhysicsCoroutine;

	private WaitForFixedUpdate mWaitForFixedUpdate;

	private List<BrainFrame> mFrameStack;

	private int mNextFrameId;

	private CinemachineBlend mCurrentLiveCameras;

	private ICinemachineCamera mActiveCameraPreviousFrame;

	private CameraState _003CCurrentCameraState_003Ek__BackingField;

	public Camera OutputCamera => null;

	public static ICinemachineCamera SoloCamera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 DefaultWorldUp => default(Vector3);

	public ICinemachineCamera ActiveVirtualCamera => null;

	public bool IsBlending => false;

	public CinemachineBlend ActiveBlend => null;

	public CameraState CurrentCameraState
	{
		get
		{
			return _003CCurrentCameraState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentCameraState_003Ek__BackingField = value;
		}
	}

	public static Color GetSoloGUIColor()
	{
		return default(Color);
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnGuiHandler()
	{
	}

	private IEnumerator AfterPhysics()
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	private float GetEffectiveDeltaTime(bool fixedDelta)
	{
		return 0f;
	}

	private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime)
	{
	}

	private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend)
	{
		return null;
	}

	private int GetBrainFrame(int withId)
	{
		return 0;
	}

	internal int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime)
	{
		return 0;
	}

	internal void ReleaseCameraOverride(int overrideId)
	{
	}

	private void ProcessActiveCamera(float deltaTime)
	{
	}

	private void UpdateFrame0(float deltaTime)
	{
	}

	private void UpdateCurrentLiveCameras()
	{
	}

	public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false)
	{
		return false;
	}

	private ICinemachineCamera TopCameraFromPriorityQueue()
	{
		return null;
	}

	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
	{
		return default(CinemachineBlendDefinition);
	}

	private void PushStateToUnityCamera(CameraState state)
	{
	}
}
