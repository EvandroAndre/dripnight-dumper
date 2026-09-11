using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCRepairArmorKitRepItem
{
	public const int PROP_ID_HEALTH = -231000;

	public const int PROP_ID_PRETIME = -231001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnPreTimeChangeEvent;

	private float _003CPreTime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float PreTime
	{
		get
		{
			return _003CPreTime_003Ek__BackingField;
		}
		private set
		{
			_003CPreTime_003Ek__BackingField = value;
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

	public UGCRepairArmorKitRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
