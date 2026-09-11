using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrenadeSmokeRepItem
{
	public const int PROP_ID_RANGE = -192000;

	public const int PROP_ID_THROWSPEED = -192001;

	public const int PROP_ID_EXPLOSIONTIME = -192002;

	public const int PROP_ID_EFFECTTIME = -192003;

	public const int PROP_ID_ASSETCONFIGID = -192004;

	public const int PROP_ID_OVERLOADBYPLAYERWEAPONSKIN = -192005;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnThrowSpeedChangeEvent;

	public Action<float> OnExplosionTimeChangeEvent;

	public Action<float> OnEffectTimeChangeEvent;

	public Action<int> OnAssetConfigIDChangeEvent;

	public Action<bool> OnOverloadByPlayerWeaponSkinChangeEvent;

	private float _003CRange_003Ek__BackingField;

	private float _003CThrowSpeed_003Ek__BackingField;

	private float _003CExplosionTime_003Ek__BackingField;

	private float _003CEffectTime_003Ek__BackingField;

	private int _003CAssetConfigID_003Ek__BackingField;

	private bool _003COverloadByPlayerWeaponSkin_003Ek__BackingField;

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

	public float EffectTime
	{
		get
		{
			return _003CEffectTime_003Ek__BackingField;
		}
		private set
		{
			_003CEffectTime_003Ek__BackingField = value;
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

	public UGCGrenadeSmokeRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
