using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCountdownReminderHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1031000;

	public const int PROP_ID_DURATIONTIMES = -1031001;

	public const int PROP_ID_DESCRIPTION = -1031002;

	public const int PROP_ID_COUNTDOWNBASETIMES = -1031003;

	public const int PROP_ID_DESCRIPTIONPARAMS = -1031004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnDurationTimeSChangeEvent;

	public Action<string> OnDescriptionChangeEvent;

	public Action<int> OnCountDownBaseTimeSChangeEvent;

	public Action<List<object>> OnDescriptionParamsChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CDurationTimeS_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private int _003CCountDownBaseTimeS_003Ek__BackingField;

	private List<object> _003CDescriptionParams_003Ek__BackingField;

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

	public List<object> DescriptionParams
	{
		get
		{
			return _003CDescriptionParams_003Ek__BackingField;
		}
		private set
		{
			_003CDescriptionParams_003Ek__BackingField = value;
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

	public UGCCountdownReminderHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
