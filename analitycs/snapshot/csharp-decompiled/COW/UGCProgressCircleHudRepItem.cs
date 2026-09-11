using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCProgressCircleHudRepItem
{
	public const int PROP_ID_OPENSTATE = -233000;

	public const int PROP_ID_DURATIONTIMES = -233001;

	public const int PROP_ID_ENDTIMES = -233002;

	public const int PROP_ID_OFFSET = -233003;

	public const int PROP_ID_ICON = -233004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnDurationTimeSChangeEvent;

	public Action<int> OnEndTimeSChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<string> OnIconChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CDurationTimeS_003Ek__BackingField;

	private int _003CEndTimeS_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private string _003CIcon_003Ek__BackingField;

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

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public string Icon
	{
		get
		{
			return _003CIcon_003Ek__BackingField;
		}
		private set
		{
			_003CIcon_003Ek__BackingField = value;
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

	public UGCProgressCircleHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
