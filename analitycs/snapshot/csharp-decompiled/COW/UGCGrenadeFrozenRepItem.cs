using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrenadeFrozenRepItem
{
	public const int PROP_ID_ZONERADIUS = -175000;

	public const int PROP_ID_ZONEDURATION = -175001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnZoneRadiusChangeEvent;

	public Action<float> OnZoneDurationChangeEvent;

	private float _003CZoneRadius_003Ek__BackingField;

	private float _003CZoneDuration_003Ek__BackingField;

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

	public UGCGrenadeFrozenRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
