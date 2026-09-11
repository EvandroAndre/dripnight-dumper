using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCarRepItem
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

	public UGCCarRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
