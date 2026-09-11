using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrenadeRepItem
{
	public const int PROP_ID_OWNER = -174000;

	public const int PROP_ID_MINDAMAGE = -174001;

	public const int PROP_ID_MAXDAMAGE = -174002;

	public const int PROP_ID_RANGE = -174003;

	public const int PROP_ID_THROWSPEED = -174004;

	public const int PROP_ID_EXPLOSIONTIME = -174005;

	public const int PROP_ID_RATIOSELF = -174006;

	public const int PROP_ID_RATIOTEAMMATE = -174007;

	public const int PROP_ID_RATIOVEHICLE = -174008;

	public const int PROP_ID_ASSETCONFIGID = -174009;

	public const int PROP_ID_OVERLOADBYPLAYERWEAPONSKIN = -174010;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMinDamageChangeEvent;

	public Action<int> OnMaxDamageChangeEvent;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnThrowSpeedChangeEvent;

	public Action<float> OnExplosionTimeChangeEvent;

	public Action<float> OnRatioSelfChangeEvent;

	public Action<float> OnRatioTeammateChangeEvent;

	public Action<float> OnRatioVehicleChangeEvent;

	public Action<int> OnAssetConfigIDChangeEvent;

	public Action<bool> OnOverloadByPlayerWeaponSkinChangeEvent;

	private int _003CMinDamage_003Ek__BackingField;

	private int _003CMaxDamage_003Ek__BackingField;

	private float _003CRange_003Ek__BackingField;

	private float _003CThrowSpeed_003Ek__BackingField;

	private float _003CExplosionTime_003Ek__BackingField;

	private float _003CRatioSelf_003Ek__BackingField;

	private float _003CRatioTeammate_003Ek__BackingField;

	private float _003CRatioVehicle_003Ek__BackingField;

	private int _003CAssetConfigID_003Ek__BackingField;

	private bool _003COverloadByPlayerWeaponSkin_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int MinDamage
	{
		get
		{
			return _003CMinDamage_003Ek__BackingField;
		}
		private set
		{
			_003CMinDamage_003Ek__BackingField = value;
		}
	}

	public int MaxDamage
	{
		get
		{
			return _003CMaxDamage_003Ek__BackingField;
		}
		private set
		{
			_003CMaxDamage_003Ek__BackingField = value;
		}
	}

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

	public float ThrowSpeed
	{
		get
		{
			return _003CThrowSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CThrowSpeed_003Ek__BackingField = value;
		}
	}

	public float ExplosionTime
	{
		get
		{
			return _003CExplosionTime_003Ek__BackingField;
		}
		private set
		{
			_003CExplosionTime_003Ek__BackingField = value;
		}
	}

	public float RatioSelf
	{
		get
		{
			return _003CRatioSelf_003Ek__BackingField;
		}
		private set
		{
			_003CRatioSelf_003Ek__BackingField = value;
		}
	}

	public float RatioTeammate
	{
		get
		{
			return _003CRatioTeammate_003Ek__BackingField;
		}
		private set
		{
			_003CRatioTeammate_003Ek__BackingField = value;
		}
	}

	public float RatioVehicle
	{
		get
		{
			return _003CRatioVehicle_003Ek__BackingField;
		}
		private set
		{
			_003CRatioVehicle_003Ek__BackingField = value;
		}
	}

	public int AssetConfigID
	{
		get
		{
			return _003CAssetConfigID_003Ek__BackingField;
		}
		private set
		{
			_003CAssetConfigID_003Ek__BackingField = value;
		}
	}

	public bool OverloadByPlayerWeaponSkin
	{
		get
		{
			return _003COverloadByPlayerWeaponSkin_003Ek__BackingField;
		}
		private set
		{
			_003COverloadByPlayerWeaponSkin_003Ek__BackingField = value;
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

	public UGCGrenadeRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
