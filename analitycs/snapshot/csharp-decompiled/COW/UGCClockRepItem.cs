using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCClockRepItem
{
	public const int PROP_ID_STARTEVENTID = -342000;

	public const int PROP_ID_STOPEVENTID = -342001;

	public const int PROP_ID_PAUSEEVENTID = -342002;

	public const int PROP_ID_STARTTIME = -342003;

	public const int PROP_ID_LOOPCOUNT = -342004;

	public const int PROP_ID_EVENTS = -342005;

	public const int PROP_ID_ISCOUNTDOWN = -342006;

	public const int PROP_ID_STATE = -342007;

	public const int PROP_ID_ENDTIMES = -342008;

	public const int PROP_ID_DURATIONTIMES = -342009;

	private UGCEntityDataStore _repDataMgr;

	public Action<long> OnStartEventIDChangeEvent;

	public Action<long> OnStopEventIDChangeEvent;

	public Action<long> OnPauseEventIDChangeEvent;

	public Action<int> OnStartTimeChangeEvent;

	public Action<int> OnLoopCountChangeEvent;

	public Action<Dictionary<object, object>> OnEventsChangeEvent;

	public Action<bool> OnIsCountdownChangeEvent;

	public Action<int> OnStateChangeEvent;

	public Action<int> OnEndTimeSChangeEvent;

	public Action<int> OnDurationTimeSChangeEvent;

	private long _003CStartEventID_003Ek__BackingField;

	private long _003CStopEventID_003Ek__BackingField;

	private long _003CPauseEventID_003Ek__BackingField;

	private int _003CStartTime_003Ek__BackingField;

	private int _003CLoopCount_003Ek__BackingField;

	private Dictionary<object, object> _003CEvents_003Ek__BackingField;

	private bool _003CIsCountdown_003Ek__BackingField;

	private int _003CState_003Ek__BackingField;

	private int _003CEndTimeS_003Ek__BackingField;

	private int _003CDurationTimeS_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public long StartEventID
	{
		get
		{
			return _003CStartEventID_003Ek__BackingField;
		}
		private set
		{
			_003CStartEventID_003Ek__BackingField = value;
		}
	}

	public long StopEventID
	{
		get
		{
			return _003CStopEventID_003Ek__BackingField;
		}
		private set
		{
			_003CStopEventID_003Ek__BackingField = value;
		}
	}

	public long PauseEventID
	{
		get
		{
			return _003CPauseEventID_003Ek__BackingField;
		}
		private set
		{
			_003CPauseEventID_003Ek__BackingField = value;
		}
	}

	public int StartTime
	{
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartTime_003Ek__BackingField = value;
		}
	}

	public int LoopCount
	{
		get
		{
			return _003CLoopCount_003Ek__BackingField;
		}
		private set
		{
			_003CLoopCount_003Ek__BackingField = value;
		}
	}

	public Dictionary<object, object> Events
	{
		get
		{
			return _003CEvents_003Ek__BackingField;
		}
		private set
		{
			_003CEvents_003Ek__BackingField = value;
		}
	}

	public bool IsCountdown
	{
		get
		{
			return _003CIsCountdown_003Ek__BackingField;
		}
		private set
		{
			_003CIsCountdown_003Ek__BackingField = value;
		}
	}

	public int State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		private set
		{
			_003CState_003Ek__BackingField = value;
		}
	}

	public int EndTimeS
	{
		get
		{
			return _003CEndTimeS_003Ek__BackingField;
		}
		private set
		{
			_003CEndTimeS_003Ek__BackingField = value;
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

	public UGCClockRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
