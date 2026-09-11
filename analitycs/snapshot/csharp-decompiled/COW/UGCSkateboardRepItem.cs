using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSkateboardRepItem
{
	public const int PROP_ID_SPEED = -206000;

	public const int PROP_ID_ACCELERATE = -206001;

	public const int PROP_ID_BOOSTSPEED = -206002;

	public const int PROP_ID_BOOSTDURATION = -206003;

	public const int PROP_ID_BOOSTCOOLDOWN = -206004;

	public const int PROP_ID_JUMPHEIGHT = -206005;

	public const int PROP_ID_HBJUMPCD = -206006;

	public const int PROP_ID_HBBOOSTINITIAL = -206007;

	public const int PROP_ID_HBBOOSTCDSWITCH = -206008;

	public const int PROP_ID_HOVERBOARDCDMS = -206009;

	public const int PROP_ID_HIGHSPEEDSTEERANGLE = -206010;

	public const int PROP_ID_HIGHSPEEDSTEERANGLEATSPEED = -206011;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnSpeedChangeEvent;

	public Action<float> OnAccelerateChangeEvent;

	public Action<float> OnBoostSpeedChangeEvent;

	public Action<float> OnBoostDurationChangeEvent;

	public Action<float> OnBoostCooldownChangeEvent;

	public Action<float> OnJumpHeightChangeEvent;

	public Action<float> OnHBJumpCDChangeEvent;

	public Action<float> OnHBBoostInitialChangeEvent;

	public Action<bool> OnHBBoostCDSwitchChangeEvent;

	public Action<float> OnHoverboardCDMsChangeEvent;

	public Action<float> OnHighSpeedSteerAngleChangeEvent;

	public Action<float> OnHighSpeedSteerAngleAtSpeedChangeEvent;

	private float _003CSpeed_003Ek__BackingField;

	private float _003CAccelerate_003Ek__BackingField;

	private float _003CBoostSpeed_003Ek__BackingField;

	private float _003CBoostDuration_003Ek__BackingField;

	private float _003CBoostCooldown_003Ek__BackingField;

	private float _003CJumpHeight_003Ek__BackingField;

	private float _003CHBJumpCD_003Ek__BackingField;

	private float _003CHBBoostInitial_003Ek__BackingField;

	private bool _003CHBBoostCDSwitch_003Ek__BackingField;

	private float _003CHoverboardCDMs_003Ek__BackingField;

	private float _003CHighSpeedSteerAngle_003Ek__BackingField;

	private float _003CHighSpeedSteerAngleAtSpeed_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Speed
	{
		get
		{
			return _003CSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CSpeed_003Ek__BackingField = value;
		}
	}

	public float Accelerate
	{
		get
		{
			return _003CAccelerate_003Ek__BackingField;
		}
		private set
		{
			_003CAccelerate_003Ek__BackingField = value;
		}
	}

	public float BoostSpeed
	{
		get
		{
			return _003CBoostSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CBoostSpeed_003Ek__BackingField = value;
		}
	}

	public float BoostDuration
	{
		get
		{
			return _003CBoostDuration_003Ek__BackingField;
		}
		private set
		{
			_003CBoostDuration_003Ek__BackingField = value;
		}
	}

	public float BoostCooldown
	{
		get
		{
			return _003CBoostCooldown_003Ek__BackingField;
		}
		private set
		{
			_003CBoostCooldown_003Ek__BackingField = value;
		}
	}

	public float JumpHeight
	{
		get
		{
			return _003CJumpHeight_003Ek__BackingField;
		}
		private set
		{
			_003CJumpHeight_003Ek__BackingField = value;
		}
	}

	public float HBJumpCD
	{
		get
		{
			return _003CHBJumpCD_003Ek__BackingField;
		}
		private set
		{
			_003CHBJumpCD_003Ek__BackingField = value;
		}
	}

	public float HBBoostInitial
	{
		get
		{
			return _003CHBBoostInitial_003Ek__BackingField;
		}
		private set
		{
			_003CHBBoostInitial_003Ek__BackingField = value;
		}
	}

	public bool HBBoostCDSwitch
	{
		get
		{
			return _003CHBBoostCDSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CHBBoostCDSwitch_003Ek__BackingField = value;
		}
	}

	public float HoverboardCDMs
	{
		get
		{
			return _003CHoverboardCDMs_003Ek__BackingField;
		}
		private set
		{
			_003CHoverboardCDMs_003Ek__BackingField = value;
		}
	}

	public float HighSpeedSteerAngle
	{
		get
		{
			return _003CHighSpeedSteerAngle_003Ek__BackingField;
		}
		private set
		{
			_003CHighSpeedSteerAngle_003Ek__BackingField = value;
		}
	}

	public float HighSpeedSteerAngleAtSpeed
	{
		get
		{
			return _003CHighSpeedSteerAngleAtSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CHighSpeedSteerAngleAtSpeed_003Ek__BackingField = value;
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

	public UGCSkateboardRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
