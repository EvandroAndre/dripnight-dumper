using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAttachmentRepItem
{
	public const int PROP_ID_RANGE = -318000;

	public const int PROP_ID_FULLDAMAGEDISTANCE = -318001;

	public const int PROP_ID_MINDAMAGEDISTANCE = -318002;

	public const int PROP_ID_AMMOCLIPSIZE = -318003;

	public const int PROP_ID_FIREINTERVAL = -318004;

	public const int PROP_ID_RELOADSPEED = -318005;

	public const int PROP_ID_FASTAUTORELOADSPEED = -318006;

	public const int PROP_ID_SCATTERSPEED = -318007;

	public const int PROP_ID_SCATTERSPEEDCROUCHCREEP = -318008;

	public const int PROP_ID_SCATTERMAX = -318009;

	public const int PROP_ID_PLAYERSPEEDFACTORAIMING = -318010;

	public const int PROP_ID_SIGHTAMPLIFYRATIO = -318011;

	public const int PROP_ID_SIGHTFOVAMPLIFYRATIO = -318012;

	public const int PROP_ID_SIGHTUIACTIONRATIO = -318013;

	public const int PROP_ID_SIGHTUIACTIONEXPAND = -318014;

	public const int PROP_ID_SIGHTUIACTIONRECOVERY = -318015;

	public const int PROP_ID_SIGHTSHOOTMINDAMAGE = -318016;

	public const int PROP_ID_SIGHTAIMASSIST = -318017;

	public const int PROP_ID_SIGHTAIMASSISTSNAPRANGE = -318018;

	public const int PROP_ID_SIGHTAIMASSISTDISTFALLOFF = -318019;

	public const int PROP_ID_SIGHTAIMASSISTDISTPRIORITY = -318020;

	public const int PROP_ID_SIGHTAIMASSISTDISTPRIOMIN = -318021;

	public const int PROP_ID_SIGHTAIMASSISTDISTPRIOMAX = -318022;

	public const int PROP_ID_SIGHTAIMASSISTDISTPRIOCOEF = -318023;

	public const int PROP_ID_SIGHTROTSENSITIVENESS = -318024;

	public const int PROP_ID_SHRINKSPEED = -318025;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnFullDamageDistanceChangeEvent;

	public Action<float> OnMinDamageDistanceChangeEvent;

	public Action<int> OnAmmoClipSizeChangeEvent;

	public Action<float> OnFireIntervalChangeEvent;

	public Action<float> OnReloadSpeedChangeEvent;

	public Action<float> OnFastAutoReloadSpeedChangeEvent;

	public Action<float> OnScatterSpeedChangeEvent;

	public Action<float> OnScatterSpeedCrouchCreepChangeEvent;

	public Action<float> OnScatterMaxChangeEvent;

	public Action<float> OnPlayerSpeedFactorAimingChangeEvent;

	public Action<int> OnSightAmplifyRatioChangeEvent;

	public Action<float> OnSightFOVAmplifyRatioChangeEvent;

	public Action<float> OnSightUiActionRatioChangeEvent;

	public Action<float> OnSightUiActionExpandChangeEvent;

	public Action<float> OnSightUiActionRecoveryChangeEvent;

	public Action<int> OnSightShootMinDamageChangeEvent;

	public Action<bool> OnSightAimAssistChangeEvent;

	public Action<float> OnSightAimAssistSnapRangeChangeEvent;

	public Action<float> OnSightAimAssistDistFalloffChangeEvent;

	public Action<bool> OnSightAimAssistDistpriorityChangeEvent;

	public Action<float> OnSightAimAssistDistprioMinChangeEvent;

	public Action<float> OnSightAimAssistDistprioMaxChangeEvent;

	public Action<float> OnSightAimAssistDistprioCoefChangeEvent;

	public Action<float> OnSightRotSensitivenessChangeEvent;

	public Action<float> OnShrinkSpeedChangeEvent;

	private float _003CRange_003Ek__BackingField;

	private float _003CFullDamageDistance_003Ek__BackingField;

	private float _003CMinDamageDistance_003Ek__BackingField;

	private int _003CAmmoClipSize_003Ek__BackingField;

	private float _003CFireInterval_003Ek__BackingField;

	private float _003CReloadSpeed_003Ek__BackingField;

	private float _003CFastAutoReloadSpeed_003Ek__BackingField;

	private float _003CScatterSpeed_003Ek__BackingField;

	private float _003CScatterSpeedCrouchCreep_003Ek__BackingField;

	private float _003CScatterMax_003Ek__BackingField;

	private float _003CPlayerSpeedFactorAiming_003Ek__BackingField;

	private int _003CSightAmplifyRatio_003Ek__BackingField;

	private float _003CSightFOVAmplifyRatio_003Ek__BackingField;

	private float _003CSightUiActionRatio_003Ek__BackingField;

	private float _003CSightUiActionExpand_003Ek__BackingField;

	private float _003CSightUiActionRecovery_003Ek__BackingField;

	private int _003CSightShootMinDamage_003Ek__BackingField;

	private bool _003CSightAimAssist_003Ek__BackingField;

	private float _003CSightAimAssistSnapRange_003Ek__BackingField;

	private float _003CSightAimAssistDistFalloff_003Ek__BackingField;

	private bool _003CSightAimAssistDistpriority_003Ek__BackingField;

	private float _003CSightAimAssistDistprioMin_003Ek__BackingField;

	private float _003CSightAimAssistDistprioMax_003Ek__BackingField;

	private float _003CSightAimAssistDistprioCoef_003Ek__BackingField;

	private float _003CSightRotSensitiveness_003Ek__BackingField;

	private float _003CShrinkSpeed_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Range
	{
		get
		{
			return _003CRange_003Ek__BackingField;
		}
		private set
		{
			_003CRange_003Ek__BackingField = value;
		}
	}

	public float FullDamageDistance
	{
		get
		{
			return _003CFullDamageDistance_003Ek__BackingField;
		}
		private set
		{
			_003CFullDamageDistance_003Ek__BackingField = value;
		}
	}

	public float MinDamageDistance
	{
		get
		{
			return _003CMinDamageDistance_003Ek__BackingField;
		}
		private set
		{
			_003CMinDamageDistance_003Ek__BackingField = value;
		}
	}

	public int AmmoClipSize
	{
		get
		{
			return _003CAmmoClipSize_003Ek__BackingField;
		}
		private set
		{
			_003CAmmoClipSize_003Ek__BackingField = value;
		}
	}

	public float FireInterval
	{
		get
		{
			return _003CFireInterval_003Ek__BackingField;
		}
		private set
		{
			_003CFireInterval_003Ek__BackingField = value;
		}
	}

	public float ReloadSpeed
	{
		get
		{
			return _003CReloadSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CReloadSpeed_003Ek__BackingField = value;
		}
	}

	public float FastAutoReloadSpeed
	{
		get
		{
			return _003CFastAutoReloadSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CFastAutoReloadSpeed_003Ek__BackingField = value;
		}
	}

	public float ScatterSpeed
	{
		get
		{
			return _003CScatterSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CScatterSpeed_003Ek__BackingField = value;
		}
	}

	public float ScatterSpeedCrouchCreep
	{
		get
		{
			return _003CScatterSpeedCrouchCreep_003Ek__BackingField;
		}
		private set
		{
			_003CScatterSpeedCrouchCreep_003Ek__BackingField = value;
		}
	}

	public float ScatterMax
	{
		get
		{
			return _003CScatterMax_003Ek__BackingField;
		}
		private set
		{
			_003CScatterMax_003Ek__BackingField = value;
		}
	}

	public float PlayerSpeedFactorAiming
	{
		get
		{
			return _003CPlayerSpeedFactorAiming_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerSpeedFactorAiming_003Ek__BackingField = value;
		}
	}

	public int SightAmplifyRatio
	{
		get
		{
			return _003CSightAmplifyRatio_003Ek__BackingField;
		}
		private set
		{
			_003CSightAmplifyRatio_003Ek__BackingField = value;
		}
	}

	public float SightFOVAmplifyRatio
	{
		get
		{
			return _003CSightFOVAmplifyRatio_003Ek__BackingField;
		}
		private set
		{
			_003CSightFOVAmplifyRatio_003Ek__BackingField = value;
		}
	}

	public float SightUiActionRatio
	{
		get
		{
			return _003CSightUiActionRatio_003Ek__BackingField;
		}
		private set
		{
			_003CSightUiActionRatio_003Ek__BackingField = value;
		}
	}

	public float SightUiActionExpand
	{
		get
		{
			return _003CSightUiActionExpand_003Ek__BackingField;
		}
		private set
		{
			_003CSightUiActionExpand_003Ek__BackingField = value;
		}
	}

	public float SightUiActionRecovery
	{
		get
		{
			return _003CSightUiActionRecovery_003Ek__BackingField;
		}
		private set
		{
			_003CSightUiActionRecovery_003Ek__BackingField = value;
		}
	}

	public int SightShootMinDamage
	{
		get
		{
			return _003CSightShootMinDamage_003Ek__BackingField;
		}
		private set
		{
			_003CSightShootMinDamage_003Ek__BackingField = value;
		}
	}

	public bool SightAimAssist
	{
		get
		{
			return _003CSightAimAssist_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssist_003Ek__BackingField = value;
		}
	}

	public float SightAimAssistSnapRange
	{
		get
		{
			return _003CSightAimAssistSnapRange_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssistSnapRange_003Ek__BackingField = value;
		}
	}

	public float SightAimAssistDistFalloff
	{
		get
		{
			return _003CSightAimAssistDistFalloff_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssistDistFalloff_003Ek__BackingField = value;
		}
	}

	public bool SightAimAssistDistpriority
	{
		get
		{
			return _003CSightAimAssistDistpriority_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssistDistpriority_003Ek__BackingField = value;
		}
	}

	public float SightAimAssistDistprioMin
	{
		get
		{
			return _003CSightAimAssistDistprioMin_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssistDistprioMin_003Ek__BackingField = value;
		}
	}

	public float SightAimAssistDistprioMax
	{
		get
		{
			return _003CSightAimAssistDistprioMax_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssistDistprioMax_003Ek__BackingField = value;
		}
	}

	public float SightAimAssistDistprioCoef
	{
		get
		{
			return _003CSightAimAssistDistprioCoef_003Ek__BackingField;
		}
		private set
		{
			_003CSightAimAssistDistprioCoef_003Ek__BackingField = value;
		}
	}

	public float SightRotSensitiveness
	{
		get
		{
			return _003CSightRotSensitiveness_003Ek__BackingField;
		}
		private set
		{
			_003CSightRotSensitiveness_003Ek__BackingField = value;
		}
	}

	public float ShrinkSpeed
	{
		get
		{
			return _003CShrinkSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CShrinkSpeed_003Ek__BackingField = value;
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

	public UGCAttachmentRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
