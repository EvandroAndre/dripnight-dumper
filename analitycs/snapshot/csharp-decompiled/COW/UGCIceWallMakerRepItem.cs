using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCIceWallMakerRepItem
{
	public const int PROP_ID_EXPPERDAMAGE = -307000;

	public const int PROP_ID_EXPPERMOVEMILE = -307001;

	public const int PROP_ID_EXPPERSECOND = -307002;

	public const int PROP_ID_EXPCHIP = -307003;

	public const int PROP_ID_CHARGEMAX = -307004;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnChargeMaxChangeEvent;

	private float _003CChargeMax_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float ChargeMax
	{
		get
		{
			return _003CChargeMax_003Ek__BackingField;
		}
		private set
		{
			_003CChargeMax_003Ek__BackingField = value;
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

	public UGCIceWallMakerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
