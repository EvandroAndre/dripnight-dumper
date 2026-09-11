using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPhaseCountDownHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1021000;

	public const int PROP_ID_BASETIMES = -1021001;

	public const int PROP_ID_DURATIONTIMES = -1021002;

	public const int PROP_ID_OFFSET = -1021003;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnBaseTimeSChangeEvent;

	public Action<int> OnDurationTimeSChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CBaseTimeS_003Ek__BackingField;

	private int _003CDurationTimeS_003Ek__BackingField;

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

	public int BaseTimeS
	{
		get
		{
			return _003CBaseTimeS_003Ek__BackingField;
		}
		private set
		{
			_003CBaseTimeS_003Ek__BackingField = value;
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

	public UGCPhaseCountDownHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
