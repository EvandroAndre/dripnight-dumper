using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine;

public sealed class CinemachineCore
{
	public enum Stage
	{
		Body,
		Aim,
		Noise,
		Finalize
	}

	public delegate float AxisInputDelegate(string axisName);

	public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner);

	private class UpdateStatus
	{
		public int lastUpdateFrame;

		public int lastUpdateFixedFrame;

		public UpdateTracker.UpdateClock lastUpdateMode;
	}

	internal enum UpdateFilter
	{
		Fixed = 0,
		Late = 1,
		Smart = 8,
		SmartFixed = Smart,
		SmartLate = 9
	}

	public static readonly int kStreamingVersion;

	public static readonly string kVersionString;

	private static CinemachineCore sInstance;

	public static bool sShowHiddenObjects;

	public static AxisInputDelegate GetInputAxis;

	public static GetBlendOverrideDelegate GetBlendOverride;

	public static CinemachineBrain.BrainEvent CameraUpdatedEvent;

	private List<CinemachineBrain> mActiveBrains;

	private List<CinemachineVirtualCameraBase> mActiveCameras;

	private List<List<CinemachineVirtualCameraBase>> mAllCameras;

	private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame;

	private static float mLastUpdateTime;

	private static int _003CFixedFrameCount_003Ek__BackingField;

	private static Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus;

	private UpdateFilter _003CCurrentUpdateFilter_003Ek__BackingField;

	public static CinemachineCore Instance => null;

	public int BrainCount => 0;

	public int VirtualCameraCount => 0;

	private static int FixedFrameCount
	{
		get
		{
			return _003CFixedFrameCount_003Ek__BackingField;
		}
		set
		{
			_003CFixedFrameCount_003Ek__BackingField = value;
		}
	}

	internal UpdateFilter CurrentUpdateFilter
	{
		get
		{
			return _003CCurrentUpdateFilter_003Ek__BackingField;
		}
		set
		{
			_003CCurrentUpdateFilter_003Ek__BackingField = value;
		}
	}

	public CinemachineBrain GetActiveBrain(int index)
	{
		return null;
	}

	internal void AddActiveBrain(CinemachineBrain brain)
	{
	}

	internal void RemoveActiveBrain(CinemachineBrain brain)
	{
	}

	public CinemachineVirtualCameraBase GetVirtualCamera(int index)
	{
		return null;
	}

	internal void AddActiveCamera(CinemachineVirtualCameraBase vcam)
	{
	}

	internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam)
	{
	}

	internal void CameraAwakened(CinemachineVirtualCameraBase vcam)
	{
	}

	internal void CameraDestroyed(CinemachineVirtualCameraBase vcam)
	{
	}

	internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime)
	{
	}

	internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime)
	{
	}

	private static void InitializeModule()
	{
	}

	private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam)
	{
		return null;
	}

	public UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam)
	{
		return UpdateTracker.UpdateClock.Fixed;
	}

	public bool IsLive(ICinemachineCamera vcam)
	{
		return false;
	}

	public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom)
	{
	}

	public void GenerateCameraCutEvent(ICinemachineCamera vcam)
	{
	}

	public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam)
	{
		return null;
	}
}
