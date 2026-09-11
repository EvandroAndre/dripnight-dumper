using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCVehicleRepItem
{
	public const int PROP_ID_ENGINETORQUE = -56000;

	public const int PROP_ID_BRAKETORQUE = -56001;

	public const int PROP_ID_HIGHSPEEDSTEERANGLE = -56002;

	public const int PROP_ID_HIGHSPEEDSTEERANGLEATSPEED = -56003;

	public const int PROP_ID_MAXSPEED = -56004;

	public const int PROP_ID_IDLEBRAKEINPUT = -56005;

	public const int PROP_ID_CRASHMESSFACTOR = -56006;

	public const int PROP_ID_CRASHMAXSPEED = -56007;

	public const int PROP_ID_CRASHMINDAMAGE = -56008;

	public const int PROP_ID_CRASHMAXDAMAGE = -56009;

	public const int PROP_ID_EXPLODEDELAY = -56010;

	public const int PROP_ID_EXPLODERANGE = -56011;

	public const int PROP_ID_EXPLODEDAMAGE = -56012;

	public const int PROP_ID_BURNTIME = -56013;

	public const int PROP_ID_BURNDAMAGE = -56014;

	public const int PROP_ID_BURNINTERVAL = -56015;

	public const int PROP_ID_HP = -56016;

	public const int PROP_ID_DRIVER = -56017;

	public const int PROP_ID_PASSENGERS = -56018;

	public const int PROP_ID_VEHICLESKINID = -56019;

	public const int PROP_ID_OVERLOADBYPLAYERSKIN = -56020;

	public const int PROP_ID_MAXHP = -56021;

	public const int PROP_ID_CURRENTHP = -56022;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnEngineTorqueChangeEvent;

	public Action<float> OnBrakeTorqueChangeEvent;

	public Action<float> OnHighSpeedSteerAngleChangeEvent;

	public Action<float> OnHighSpeedSteerAngleAtspeedChangeEvent;

	public Action<float> OnMaxSpeedChangeEvent;

	public Action<float> OnIdleBrakeInputChangeEvent;

	public Action<float> OnCrashMessFactorChangeEvent;

	public Action<float> OnCrashMaxSpeedChangeEvent;

	public Action<float> OnCrashMinDamageChangeEvent;

	public Action<float> OnCrashMaxDamageChangeEvent;

	public Action<float> OnExplodeDelayChangeEvent;

	public Action<float> OnExplodeRangeChangeEvent;

	public Action<int> OnExplodeDamageChangeEvent;

	public Action<float> OnBurnTimeChangeEvent;

	public Action<int> OnBurnDamageChangeEvent;

	public Action<float> OnBurnIntervalChangeEvent;

	public Action<int> OnHPChangeEvent;

	public Action<int> OnVehicleSkinIDChangeEvent;

	public Action<bool> OnOverloadByPlayerSkinChangeEvent;

	public Action<int> OnMaxHPChangeEvent;

	public Action<int> OnCurrentHPChangeEvent;

	private float _003CEngineTorque_003Ek__BackingField;

	private float _003CBrakeTorque_003Ek__BackingField;

	private float _003CHighSpeedSteerAngle_003Ek__BackingField;

	private float _003CHighSpeedSteerAngleAtspeed_003Ek__BackingField;

	private float _003CMaxSpeed_003Ek__BackingField;

	private float _003CIdleBrakeInput_003Ek__BackingField;

	private float _003CCrashMessFactor_003Ek__BackingField;

	private float _003CCrashMaxSpeed_003Ek__BackingField;

	private float _003CCrashMinDamage_003Ek__BackingField;

	private float _003CCrashMaxDamage_003Ek__BackingField;

	private float _003CExplodeDelay_003Ek__BackingField;

	private float _003CExplodeRange_003Ek__BackingField;

	private int _003CExplodeDamage_003Ek__BackingField;

	private float _003CBurnTime_003Ek__BackingField;

	private int _003CBurnDamage_003Ek__BackingField;

	private float _003CBurnInterval_003Ek__BackingField;

	private int _003CHP_003Ek__BackingField;

	private int _003CVehicleSkinID_003Ek__BackingField;

	private bool _003COverloadByPlayerSkin_003Ek__BackingField;

	private int _003CMaxHP_003Ek__BackingField;

	private int _003CCurrentHP_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float EngineTorque
	{
		get
		{
			return _003CEngineTorque_003Ek__BackingField;
		}
		private set
		{
			_003CEngineTorque_003Ek__BackingField = value;
		}
	}

	public float BrakeTorque
	{
		get
		{
			return _003CBrakeTorque_003Ek__BackingField;
		}
		private set
		{
			_003CBrakeTorque_003Ek__BackingField = value;
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

	public float HighSpeedSteerAngleAtspeed
	{
		get
		{
			return _003CHighSpeedSteerAngleAtspeed_003Ek__BackingField;
		}
		private set
		{
			_003CHighSpeedSteerAngleAtspeed_003Ek__BackingField = value;
		}
	}

	public float MaxSpeed
	{
		get
		{
			return _003CMaxSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CMaxSpeed_003Ek__BackingField = value;
		}
	}

	public float IdleBrakeInput
	{
		get
		{
			return _003CIdleBrakeInput_003Ek__BackingField;
		}
		private set
		{
			_003CIdleBrakeInput_003Ek__BackingField = value;
		}
	}

	public float CrashMessFactor
	{
		get
		{
			return _003CCrashMessFactor_003Ek__BackingField;
		}
		private set
		{
			_003CCrashMessFactor_003Ek__BackingField = value;
		}
	}

	public float CrashMaxSpeed
	{
		get
		{
			return _003CCrashMaxSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CCrashMaxSpeed_003Ek__BackingField = value;
		}
	}

	public float CrashMinDamage
	{
		get
		{
			return _003CCrashMinDamage_003Ek__BackingField;
		}
		private set
		{
			_003CCrashMinDamage_003Ek__BackingField = value;
		}
	}

	public float CrashMaxDamage
	{
		get
		{
			return _003CCrashMaxDamage_003Ek__BackingField;
		}
		private set
		{
			_003CCrashMaxDamage_003Ek__BackingField = value;
		}
	}

	public float ExplodeDelay
	{
		get
		{
			return _003CExplodeDelay_003Ek__BackingField;
		}
		private set
		{
			_003CExplodeDelay_003Ek__BackingField = value;
		}
	}

	public float ExplodeRange
	{
		get
		{
			return _003CExplodeRange_003Ek__BackingField;
		}
		private set
		{
			_003CExplodeRange_003Ek__BackingField = value;
		}
	}

	public int ExplodeDamage
	{
		get
		{
			return _003CExplodeDamage_003Ek__BackingField;
		}
		private set
		{
			_003CExplodeDamage_003Ek__BackingField = value;
		}
	}

	public float BurnTime
	{
		get
		{
			return _003CBurnTime_003Ek__BackingField;
		}
		private set
		{
			_003CBurnTime_003Ek__BackingField = value;
		}
	}

	public int BurnDamage
	{
		get
		{
			return _003CBurnDamage_003Ek__BackingField;
		}
		private set
		{
			_003CBurnDamage_003Ek__BackingField = value;
		}
	}

	public float BurnInterval
	{
		get
		{
			return _003CBurnInterval_003Ek__BackingField;
		}
		private set
		{
			_003CBurnInterval_003Ek__BackingField = value;
		}
	}

	public int HP
	{
		get
		{
			return _003CHP_003Ek__BackingField;
		}
		private set
		{
			_003CHP_003Ek__BackingField = value;
		}
	}

	public int VehicleSkinID
	{
		get
		{
			return _003CVehicleSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CVehicleSkinID_003Ek__BackingField = value;
		}
	}

	public bool OverloadByPlayerSkin
	{
		get
		{
			return _003COverloadByPlayerSkin_003Ek__BackingField;
		}
		private set
		{
			_003COverloadByPlayerSkin_003Ek__BackingField = value;
		}
	}

	public int MaxHP
	{
		get
		{
			return _003CMaxHP_003Ek__BackingField;
		}
		private set
		{
			_003CMaxHP_003Ek__BackingField = value;
		}
	}

	public int CurrentHP
	{
		get
		{
			return _003CCurrentHP_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentHP_003Ek__BackingField = value;
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

	public UGCVehicleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
