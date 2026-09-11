using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrenadeWeaponRepItem
{
	public const int PROP_ID_GRENADEMINDAMAGE = -311000;

	public const int PROP_ID_GRENADEMAXDAMAGE = -311001;

	public const int PROP_ID_GRENADERANGE = -311002;

	public const int PROP_ID_GRENADETHROWSPEED = -311003;

	public const int PROP_ID_GRENADEEXPLOSIONTIME = -311004;

	public const int PROP_ID_GRENADERATIOSELF = -311005;

	public const int PROP_ID_GRENADERATIOTEAMMATE = -311006;

	public const int PROP_ID_GRENADERATIOVEHICLE = -311007;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnGrenadeMinDamageChangeEvent;

	public Action<int> OnGrenadeMaxDamageChangeEvent;

	public Action<float> OnGrenadeRangeChangeEvent;

	public Action<float> OnGrenadeThrowSpeedChangeEvent;

	public Action<float> OnGrenadeExplosionTimeChangeEvent;

	public Action<float> OnGrenadeRatioSelfChangeEvent;

	public Action<float> OnGrenadeRatioTeammateChangeEvent;

	public Action<float> OnGrenadeRatioVehicleChangeEvent;

	private int _003CGrenadeMinDamage_003Ek__BackingField;

	private int _003CGrenadeMaxDamage_003Ek__BackingField;

	private float _003CGrenadeRange_003Ek__BackingField;

	private float _003CGrenadeThrowSpeed_003Ek__BackingField;

	private float _003CGrenadeExplosionTime_003Ek__BackingField;

	private float _003CGrenadeRatioSelf_003Ek__BackingField;

	private float _003CGrenadeRatioTeammate_003Ek__BackingField;

	private float _003CGrenadeRatioVehicle_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int GrenadeMinDamage
	{
		get
		{
			return _003CGrenadeMinDamage_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeMinDamage_003Ek__BackingField = value;
		}
	}

	public int GrenadeMaxDamage
	{
		get
		{
			return _003CGrenadeMaxDamage_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeMaxDamage_003Ek__BackingField = value;
		}
	}

	public float GrenadeRange
	{
		get
		{
			return _003CGrenadeRange_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeRange_003Ek__BackingField = value;
		}
	}

	public float GrenadeThrowSpeed
	{
		get
		{
			return _003CGrenadeThrowSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeThrowSpeed_003Ek__BackingField = value;
		}
	}

	public float GrenadeExplosionTime
	{
		get
		{
			return _003CGrenadeExplosionTime_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeExplosionTime_003Ek__BackingField = value;
		}
	}

	public float GrenadeRatioSelf
	{
		get
		{
			return _003CGrenadeRatioSelf_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeRatioSelf_003Ek__BackingField = value;
		}
	}

	public float GrenadeRatioTeammate
	{
		get
		{
			return _003CGrenadeRatioTeammate_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeRatioTeammate_003Ek__BackingField = value;
		}
	}

	public float GrenadeRatioVehicle
	{
		get
		{
			return _003CGrenadeRatioVehicle_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeRatioVehicle_003Ek__BackingField = value;
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

	public UGCGrenadeWeaponRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
