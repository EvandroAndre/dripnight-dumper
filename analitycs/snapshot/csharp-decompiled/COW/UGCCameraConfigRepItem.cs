using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCCameraConfigRepItem
{
	public const int PROP_ID_CAMERATYPE = -148000;

	public const int PROP_ID_FOV = -148001;

	public const int PROP_ID_OFFSET = -148002;

	public const int PROP_ID_OFFSET2 = -148003;

	public const int PROP_ID_PITCH = -148004;

	public const int PROP_ID_YAW = -148005;

	public const int PROP_ID_DISTANCE = -148006;

	public const int PROP_ID_FOLLOWTARGET = -148007;

	public const int PROP_ID_FOCUSTARGET = -148008;

	public const int PROP_ID_USEENTITIES = -148009;

	public const int PROP_ID_CAMERATRANSITIONTYPE = -148010;

	public const int PROP_ID_CAMERATRANSITIONTIME = -148011;

	public const int PROP_ID_CAMERABLOCKMODE = -148012;

	public const int PROP_ID_CAMERAPROJECTIONMODE = -148013;

	public const int PROP_ID_FOLLOWCOORDINATETYPE = -148014;

	public const int PROP_ID_FOCUSCOORDINATETYPE = -148015;

	public const int PROP_ID_CULLINGMASK = -148016;

	public const int PROP_ID_VIEWINGANGLERESTRICTION = -148017;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnCameraTypeChangeEvent;

	public Action<float> OnFovChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<Vector3> OnOffset2ChangeEvent;

	public Action<float> OnPitchChangeEvent;

	public Action<float> OnYawChangeEvent;

	public Action<float> OnDistanceChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<string> OnFocusTargetChangeEvent;

	public Action<int> OnCameraTransitionTypeChangeEvent;

	public Action<float> OnCameraTransitionTimeChangeEvent;

	public Action<int> OnCameraBlockModeChangeEvent;

	public Action<int> OnCameraProjectionModeChangeEvent;

	public Action<int> OnFollowCoordinateTypeChangeEvent;

	public Action<int> OnFocusCoordinateTypeChangeEvent;

	public Action<int> OnCullingMaskChangeEvent;

	public Action<int> OnViewingAngleRestrictionChangeEvent;

	private int _003CCameraType_003Ek__BackingField;

	private float _003CFov_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private Vector3 _003COffset2_003Ek__BackingField;

	private float _003CPitch_003Ek__BackingField;

	private float _003CYaw_003Ek__BackingField;

	private float _003CDistance_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private string _003CFocusTarget_003Ek__BackingField;

	private int _003CCameraTransitionType_003Ek__BackingField;

	private float _003CCameraTransitionTime_003Ek__BackingField;

	private int _003CCameraBlockMode_003Ek__BackingField;

	private int _003CCameraProjectionMode_003Ek__BackingField;

	private int _003CFollowCoordinateType_003Ek__BackingField;

	private int _003CFocusCoordinateType_003Ek__BackingField;

	private int _003CCullingMask_003Ek__BackingField;

	private int _003CViewingAngleRestriction_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int CameraType
	{
		get
		{
			return _003CCameraType_003Ek__BackingField;
		}
		private set
		{
			_003CCameraType_003Ek__BackingField = value;
		}
	}

	public float Fov
	{
		get
		{
			return _003CFov_003Ek__BackingField;
		}
		private set
		{
			_003CFov_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset2
	{
		get
		{
			return _003COffset2_003Ek__BackingField;
		}
		private set
		{
			_003COffset2_003Ek__BackingField = value;
		}
	}

	public float Pitch
	{
		get
		{
			return _003CPitch_003Ek__BackingField;
		}
		private set
		{
			_003CPitch_003Ek__BackingField = value;
		}
	}

	public float Yaw
	{
		get
		{
			return _003CYaw_003Ek__BackingField;
		}
		private set
		{
			_003CYaw_003Ek__BackingField = value;
		}
	}

	public float Distance
	{
		get
		{
			return _003CDistance_003Ek__BackingField;
		}
		private set
		{
			_003CDistance_003Ek__BackingField = value;
		}
	}

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public string FocusTarget
	{
		get
		{
			return _003CFocusTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFocusTarget_003Ek__BackingField = value;
		}
	}

	public int CameraTransitionType
	{
		get
		{
			return _003CCameraTransitionType_003Ek__BackingField;
		}
		private set
		{
			_003CCameraTransitionType_003Ek__BackingField = value;
		}
	}

	public float CameraTransitionTime
	{
		get
		{
			return _003CCameraTransitionTime_003Ek__BackingField;
		}
		private set
		{
			_003CCameraTransitionTime_003Ek__BackingField = value;
		}
	}

	public int CameraBlockMode
	{
		get
		{
			return _003CCameraBlockMode_003Ek__BackingField;
		}
		private set
		{
			_003CCameraBlockMode_003Ek__BackingField = value;
		}
	}

	public int CameraProjectionMode
	{
		get
		{
			return _003CCameraProjectionMode_003Ek__BackingField;
		}
		private set
		{
			_003CCameraProjectionMode_003Ek__BackingField = value;
		}
	}

	public int FollowCoordinateType
	{
		get
		{
			return _003CFollowCoordinateType_003Ek__BackingField;
		}
		private set
		{
			_003CFollowCoordinateType_003Ek__BackingField = value;
		}
	}

	public int FocusCoordinateType
	{
		get
		{
			return _003CFocusCoordinateType_003Ek__BackingField;
		}
		private set
		{
			_003CFocusCoordinateType_003Ek__BackingField = value;
		}
	}

	public int CullingMask
	{
		get
		{
			return _003CCullingMask_003Ek__BackingField;
		}
		private set
		{
			_003CCullingMask_003Ek__BackingField = value;
		}
	}

	public int ViewingAngleRestriction
	{
		get
		{
			return _003CViewingAngleRestriction_003Ek__BackingField;
		}
		private set
		{
			_003CViewingAngleRestriction_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCCameraConfigRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
