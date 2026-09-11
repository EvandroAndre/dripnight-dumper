using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCCountdownHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1010000;

	public const int PROP_ID_DURATION = -1010001;

	public const int PROP_ID_BASETIME = -1010002;

	public const int PROP_ID_UPDATETYPE = -1010003;

	public const int PROP_ID_OFFSET = -1010004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnDurationChangeEvent;

	public Action<int> OnBaseTimeChangeEvent;

	public Action<int> OnUpdateTypeChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CDuration_003Ek__BackingField;

	private int _003CBaseTime_003Ek__BackingField;

	private int _003CUpdateType_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

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

	public int BaseTime
	{
		get
		{
			return _003CBaseTime_003Ek__BackingField;
		}
		private set
		{
			_003CBaseTime_003Ek__BackingField = value;
		}
	}

	public int UpdateType
	{
		get
		{
			return _003CUpdateType_003Ek__BackingField;
		}
		private set
		{
			_003CUpdateType_003Ek__BackingField = value;
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

	public UGCCountdownHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
