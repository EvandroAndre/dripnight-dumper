using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCarVehicleRepItem
{
	public const int PROP_ID_GEARSHIFTINGDELAY = -222000;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnGearShiftingDelayChangeEvent;

	private float _003CGearShiftingDelay_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float GearShiftingDelay
	{
		get
		{
			return _003CGearShiftingDelay_003Ek__BackingField;
		}
		private set
		{
			_003CGearShiftingDelay_003Ek__BackingField = value;
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

	public UGCCarVehicleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
