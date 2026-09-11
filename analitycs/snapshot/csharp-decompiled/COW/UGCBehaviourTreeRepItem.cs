using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBehaviourTreeRepItem
{
	public const int PROP_ID_TICKINTERVAL = -290000;

	public const int PROP_ID_DEBUG = -290001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnTickIntervalChangeEvent;

	public Action<bool> OnDebugChangeEvent;

	private int _003CTickInterval_003Ek__BackingField;

	private bool _003CDebug_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int TickInterval
	{
		get
		{
			return _003CTickInterval_003Ek__BackingField;
		}
		private set
		{
			_003CTickInterval_003Ek__BackingField = value;
		}
	}

	public bool Debug
	{
		get
		{
			return _003CDebug_003Ek__BackingField;
		}
		private set
		{
			_003CDebug_003Ek__BackingField = value;
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

	public UGCBehaviourTreeRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
