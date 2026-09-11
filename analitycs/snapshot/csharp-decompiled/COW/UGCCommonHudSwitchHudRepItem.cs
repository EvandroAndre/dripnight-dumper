using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCommonHudSwitchHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1044000;

	public const int PROP_ID_CROUCHSWITCH = -1044001;

	public const int PROP_ID_CREEPSWITCH = -1044002;

	public const int PROP_ID_JUMPSWITCH = -1044003;

	public const int PROP_ID_FIRESWITCH = -1044004;

	public const int PROP_ID_MOVINGJOYSTICKSWITCH = -1044005;

	public const int PROP_ID_TEAMMATESINFOSWITCH = -1044006;

	public const int PROP_ID_ATTACKGRENADESWITCH = -1044007;

	public const int PROP_ID_DEFENCEGRENADESWITCH = -1044008;

	public const int PROP_ID_SPEEDUPSWITCH = -1044009;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnCrouchSwitchChangeEvent;

	public Action<bool> OnCreepSwitchChangeEvent;

	public Action<bool> OnJumpSwitchChangeEvent;

	public Action<bool> OnFireSwitchChangeEvent;

	public Action<bool> OnMovingJoystickSwitchChangeEvent;

	public Action<bool> OnTeammatesInfoSwitchChangeEvent;

	public Action<bool> OnAttackGrenadeSwitchChangeEvent;

	public Action<bool> OnDefenceGrenadeSwitchChangeEvent;

	public Action<bool> OnSpeedupSwitchChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CCrouchSwitch_003Ek__BackingField;

	private bool _003CCreepSwitch_003Ek__BackingField;

	private bool _003CJumpSwitch_003Ek__BackingField;

	private bool _003CFireSwitch_003Ek__BackingField;

	private bool _003CMovingJoystickSwitch_003Ek__BackingField;

	private bool _003CTeammatesInfoSwitch_003Ek__BackingField;

	private bool _003CAttackGrenadeSwitch_003Ek__BackingField;

	private bool _003CDefenceGrenadeSwitch_003Ek__BackingField;

	private bool _003CSpeedupSwitch_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public bool CrouchSwitch
	{
		get
		{
			return _003CCrouchSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CCrouchSwitch_003Ek__BackingField = value;
		}
	}

	public bool CreepSwitch
	{
		get
		{
			return _003CCreepSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CCreepSwitch_003Ek__BackingField = value;
		}
	}

	public bool JumpSwitch
	{
		get
		{
			return _003CJumpSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CJumpSwitch_003Ek__BackingField = value;
		}
	}

	public bool FireSwitch
	{
		get
		{
			return _003CFireSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CFireSwitch_003Ek__BackingField = value;
		}
	}

	public bool MovingJoystickSwitch
	{
		get
		{
			return _003CMovingJoystickSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CMovingJoystickSwitch_003Ek__BackingField = value;
		}
	}

	public bool TeammatesInfoSwitch
	{
		get
		{
			return _003CTeammatesInfoSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CTeammatesInfoSwitch_003Ek__BackingField = value;
		}
	}

	public bool AttackGrenadeSwitch
	{
		get
		{
			return _003CAttackGrenadeSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CAttackGrenadeSwitch_003Ek__BackingField = value;
		}
	}

	public bool DefenceGrenadeSwitch
	{
		get
		{
			return _003CDefenceGrenadeSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CDefenceGrenadeSwitch_003Ek__BackingField = value;
		}
	}

	public bool SpeedupSwitch
	{
		get
		{
			return _003CSpeedupSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CSpeedupSwitch_003Ek__BackingField = value;
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

	public UGCCommonHudSwitchHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
