using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBigToyBallRepItem
{
	public const int PROP_ID_VELOCITYXZ = -62000;

	public const int PROP_ID_VELOCITYY = -62001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnVelocityXZChangeEvent;

	public Action<int> OnVelocityYChangeEvent;

	private int _003CVelocityXZ_003Ek__BackingField;

	private int _003CVelocityY_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int VelocityXZ
	{
		get
		{
			return _003CVelocityXZ_003Ek__BackingField;
		}
		private set
		{
			_003CVelocityXZ_003Ek__BackingField = value;
		}
	}

	public int VelocityY
	{
		get
		{
			return _003CVelocityY_003Ek__BackingField;
		}
		private set
		{
			_003CVelocityY_003Ek__BackingField = value;
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

	public UGCBigToyBallRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
