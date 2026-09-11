using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCFirstAidKitRepItem
{
	public const int PROP_ID_HEALTH = -353000;

	public const int PROP_ID_DURATION = -353001;

	public const int PROP_ID_PRETIME = -353002;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnHealthChangeEvent;

	public Action<int> OnDurationChangeEvent;

	public Action<int> OnPretimeChangeEvent;

	private int _003CHealth_003Ek__BackingField;

	private int _003CDuration_003Ek__BackingField;

	private int _003CPretime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Health
	{
		get
		{
			return _003CHealth_003Ek__BackingField;
		}
		private set
		{
			_003CHealth_003Ek__BackingField = value;
		}
	}

	public int Duration
	{
		get
		{
			return _003CDuration_003Ek__BackingField;
		}
		private set
		{
			_003CDuration_003Ek__BackingField = value;
		}
	}

	public int Pretime
	{
		get
		{
			return _003CPretime_003Ek__BackingField;
		}
		private set
		{
			_003CPretime_003Ek__BackingField = value;
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

	public UGCFirstAidKitRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
