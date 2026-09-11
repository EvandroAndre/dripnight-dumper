using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSwingGunRepItem
{
	public const int PROP_ID_TOWSPEED = -241000;

	public const int PROP_ID_SWINGSPEED = -241001;

	public const int PROP_ID_OPENTOW = -241002;

	public const int PROP_ID_OPENSWING = -241003;

	public const int PROP_ID_TARGETOBJECT = -241004;

	public const int PROP_ID_LEAVEACCELERATION = -241005;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnTowSpeedChangeEvent;

	public Action<float> OnSwingSpeedChangeEvent;

	public Action<bool> OnOpenTowChangeEvent;

	public Action<bool> OnOpenSwingChangeEvent;

	public Action<string> OnTargetObjectChangeEvent;

	public Action<float> OnLeaveAccelerationChangeEvent;

	private float _003CTowSpeed_003Ek__BackingField;

	private float _003CSwingSpeed_003Ek__BackingField;

	private bool _003COpenTow_003Ek__BackingField;

	private bool _003COpenSwing_003Ek__BackingField;

	private string _003CTargetObject_003Ek__BackingField;

	private float _003CLeaveAcceleration_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float TowSpeed
	{
		get
		{
			return _003CTowSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CTowSpeed_003Ek__BackingField = value;
		}
	}

	public float SwingSpeed
	{
		get
		{
			return _003CSwingSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CSwingSpeed_003Ek__BackingField = value;
		}
	}

	public bool OpenTow
	{
		get
		{
			return _003COpenTow_003Ek__BackingField;
		}
		private set
		{
			_003COpenTow_003Ek__BackingField = value;
		}
	}

	public bool OpenSwing
	{
		get
		{
			return _003COpenSwing_003Ek__BackingField;
		}
		private set
		{
			_003COpenSwing_003Ek__BackingField = value;
		}
	}

	public string TargetObject
	{
		get
		{
			return _003CTargetObject_003Ek__BackingField;
		}
		private set
		{
			_003CTargetObject_003Ek__BackingField = value;
		}
	}

	public float LeaveAcceleration
	{
		get
		{
			return _003CLeaveAcceleration_003Ek__BackingField;
		}
		private set
		{
			_003CLeaveAcceleration_003Ek__BackingField = value;
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

	public UGCSwingGunRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
