using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrenadeFlashRepItem
{
	public const int PROP_ID_CENTRALRANGE = -191000;

	public const int PROP_ID_RANGE = -191001;

	public const int PROP_ID_THROWSPEED = -191002;

	public const int PROP_ID_EXPLOSIONTIME = -191003;

	public const int PROP_ID_CENTERFLASHTIME = -191004;

	public const int PROP_ID_EDGEFLASHTIME = -191005;

	public const int PROP_ID_HITEFFECTSWITCH = -191006;

	public const int PROP_ID_ASSETCONFIGID = -191007;

	public const int PROP_ID_OVERLOADBYPLAYERWEAPONSKIN = -191008;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnCentralRangeChangeEvent;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnThrowSpeedChangeEvent;

	public Action<float> OnExplosionTimeChangeEvent;

	public Action<float> OnCenterFlashTimeChangeEvent;

	public Action<float> OnEdgeFlashTimeChangeEvent;

	public Action<bool> OnHitEffectSwitchChangeEvent;

	public Action<int> OnAssetConfigIDChangeEvent;

	public Action<bool> OnOverloadByPlayerWeaponSkinChangeEvent;

	private float _003CCentralRange_003Ek__BackingField;

	private float _003CRange_003Ek__BackingField;

	private float _003CThrowSpeed_003Ek__BackingField;

	private float _003CExplosionTime_003Ek__BackingField;

	private float _003CCenterFlashTime_003Ek__BackingField;

	private float _003CEdgeFlashTime_003Ek__BackingField;

	private bool _003CHitEffectSwitch_003Ek__BackingField;

	private int _003CAssetConfigID_003Ek__BackingField;

	private bool _003COverloadByPlayerWeaponSkin_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float CentralRange
	{
		get
		{
			return _003CCentralRange_003Ek__BackingField;
		}
		private set
		{
			_003CCentralRange_003Ek__BackingField = value;
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

	public float CenterFlashTime
	{
		get
		{
			return _003CCenterFlashTime_003Ek__BackingField;
		}
		private set
		{
			_003CCenterFlashTime_003Ek__BackingField = value;
		}
	}

	public float EdgeFlashTime
	{
		get
		{
			return _003CEdgeFlashTime_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeFlashTime_003Ek__BackingField = value;
		}
	}

	public bool HitEffectSwitch
	{
		get
		{
			return _003CHitEffectSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CHitEffectSwitch_003Ek__BackingField = value;
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

	public UGCGrenadeFlashRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
