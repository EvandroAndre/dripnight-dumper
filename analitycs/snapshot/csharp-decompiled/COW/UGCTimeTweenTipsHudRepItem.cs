using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTimeTweenTipsHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1039000;

	public const int PROP_ID_LOCSWITCH = -1039001;

	public const int PROP_ID_DESCRIPTION = -1039002;

	public const int PROP_ID_COUNTDOWNBASETIMES = -1039003;

	public const int PROP_ID_DURATIONTIMES = -1039004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnDescriptionChangeEvent;

	public Action<int> OnCountDownBaseTimeSChangeEvent;

	public Action<int> OnDurationTimeSChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private int _003CCountDownBaseTimeS_003Ek__BackingField;

	private int _003CDurationTimeS_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public bool LocSwitch
	{
		get
		{
			return _003CLocSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CLocSwitch_003Ek__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		private set
		{
			_003CDescription_003Ek__BackingField = value;
		}
	}

	public int CountDownBaseTimeS
	{
		get
		{
			return _003CCountDownBaseTimeS_003Ek__BackingField;
		}
		private set
		{
			_003CCountDownBaseTimeS_003Ek__BackingField = value;
		}
	}

	public int DurationTimeS
	{
		get
		{
			return _003CDurationTimeS_003Ek__BackingField;
		}
		private set
		{
			_003CDurationTimeS_003Ek__BackingField = value;
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

	public UGCTimeTweenTipsHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
