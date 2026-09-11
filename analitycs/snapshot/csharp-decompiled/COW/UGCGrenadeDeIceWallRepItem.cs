using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrenadeDeIceWallRepItem
{
	public const int PROP_ID_ZONERADIUS = -313000;

	public const int PROP_ID_ZONEDURATION = -313001;

	public const int PROP_ID_ZONEDAMAGE = -313002;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnZoneRadiusChangeEvent;

	public Action<float> OnZoneDurationChangeEvent;

	public Action<int> OnZoneDamageChangeEvent;

	private float _003CZoneRadius_003Ek__BackingField;

	private float _003CZoneDuration_003Ek__BackingField;

	private int _003CZoneDamage_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float ZoneRadius
	{
		get
		{
			return _003CZoneRadius_003Ek__BackingField;
		}
		private set
		{
			_003CZoneRadius_003Ek__BackingField = value;
		}
	}

	public float ZoneDuration
	{
		get
		{
			return _003CZoneDuration_003Ek__BackingField;
		}
		private set
		{
			_003CZoneDuration_003Ek__BackingField = value;
		}
	}

	public int ZoneDamage
	{
		get
		{
			return _003CZoneDamage_003Ek__BackingField;
		}
		private set
		{
			_003CZoneDamage_003Ek__BackingField = value;
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

	public UGCGrenadeDeIceWallRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
