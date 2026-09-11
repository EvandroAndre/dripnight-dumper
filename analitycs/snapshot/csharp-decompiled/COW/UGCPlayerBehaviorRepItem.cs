using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayerBehaviorRepItem
{
	public const int PROP_ID_MOVEMENTSTATUS = -338000;

	public const int PROP_ID_SPRINTSTATUS = -338001;

	public const int PROP_ID_ATTACKSTATUS = -338002;

	public const int PROP_ID_JUMPSTATUS = -338003;

	public const int PROP_ID_CLIMBSTATUS = -338004;

	public const int PROP_ID_GETONASDRIVERSTATUS = -338005;

	public const int PROP_ID_GETONASPASSENGERSTATUS = -338006;

	public const int PROP_ID_GETOFFVEHICLESTATUS = -338007;

	public const int PROP_ID_DRIVINGSTATUS = -338008;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMovementStatusChangeEvent;

	public Action<int> OnSprintStatusChangeEvent;

	public Action<int> OnAttackStatusChangeEvent;

	public Action<int> OnJumpStatusChangeEvent;

	public Action<int> OnClimbStatusChangeEvent;

	public Action<int> OnGetOnAsDriverStatusChangeEvent;

	public Action<int> OnGetOnAsPassengerStatusChangeEvent;

	public Action<int> OnGetOffVehicleStatusChangeEvent;

	public Action<int> OnDrivingStatusChangeEvent;

	private int _003CMovementStatus_003Ek__BackingField;

	private int _003CSprintStatus_003Ek__BackingField;

	private int _003CAttackStatus_003Ek__BackingField;

	private int _003CJumpStatus_003Ek__BackingField;

	private int _003CClimbStatus_003Ek__BackingField;

	private int _003CGetOnAsDriverStatus_003Ek__BackingField;

	private int _003CGetOnAsPassengerStatus_003Ek__BackingField;

	private int _003CGetOffVehicleStatus_003Ek__BackingField;

	private int _003CDrivingStatus_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int MovementStatus
	{
		get
		{
			return _003CMovementStatus_003Ek__BackingField;
		}
		private set
		{
			_003CMovementStatus_003Ek__BackingField = value;
		}
	}

	public int SprintStatus
	{
		get
		{
			return _003CSprintStatus_003Ek__BackingField;
		}
		private set
		{
			_003CSprintStatus_003Ek__BackingField = value;
		}
	}

	public int AttackStatus
	{
		get
		{
			return _003CAttackStatus_003Ek__BackingField;
		}
		private set
		{
			_003CAttackStatus_003Ek__BackingField = value;
		}
	}

	public int JumpStatus
	{
		get
		{
			return _003CJumpStatus_003Ek__BackingField;
		}
		private set
		{
			_003CJumpStatus_003Ek__BackingField = value;
		}
	}

	public int ClimbStatus
	{
		get
		{
			return _003CClimbStatus_003Ek__BackingField;
		}
		private set
		{
			_003CClimbStatus_003Ek__BackingField = value;
		}
	}

	public int GetOnAsDriverStatus
	{
		get
		{
			return _003CGetOnAsDriverStatus_003Ek__BackingField;
		}
		private set
		{
			_003CGetOnAsDriverStatus_003Ek__BackingField = value;
		}
	}

	public int GetOnAsPassengerStatus
	{
		get
		{
			return _003CGetOnAsPassengerStatus_003Ek__BackingField;
		}
		private set
		{
			_003CGetOnAsPassengerStatus_003Ek__BackingField = value;
		}
	}

	public int GetOffVehicleStatus
	{
		get
		{
			return _003CGetOffVehicleStatus_003Ek__BackingField;
		}
		private set
		{
			_003CGetOffVehicleStatus_003Ek__BackingField = value;
		}
	}

	public int DrivingStatus
	{
		get
		{
			return _003CDrivingStatus_003Ek__BackingField;
		}
		private set
		{
			_003CDrivingStatus_003Ek__BackingField = value;
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

	public UGCPlayerBehaviorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
