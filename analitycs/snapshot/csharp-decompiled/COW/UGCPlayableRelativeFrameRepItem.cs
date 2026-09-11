using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayableRelativeFrameRepItem
{
	public const int PROP_ID_TARGETENTITY = -347000;

	public const int PROP_ID_PROPID = -347001;

	public const int PROP_ID_DELTA = -347002;

	public const int PROP_ID_SWITCH = -347003;

	public const int PROP_ID_STARTTICKCOUNT = -347005;

	public const int PROP_ID_DELTAVALUE = -347006;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<long> OnPropIDChangeEvent;

	public Action<List<object>> OnDeltaChangeEvent;

	public Action<bool> OnSwitchChangeEvent;

	public Action<int> OnStartTickCountChangeEvent;

	public Action<object> OnDeltaValueChangeEvent;

	private string _003CTargetEntity_003Ek__BackingField;

	private long _003CPropID_003Ek__BackingField;

	private List<object> _003CDelta_003Ek__BackingField;

	private bool _003CSwitch_003Ek__BackingField;

	private int _003CStartTickCount_003Ek__BackingField;

	private object _003CDeltaValue_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string TargetEntity
	{
		get
		{
			return _003CTargetEntity_003Ek__BackingField;
		}
		private set
		{
			_003CTargetEntity_003Ek__BackingField = value;
		}
	}

	public long PropID
	{
		get
		{
			return _003CPropID_003Ek__BackingField;
		}
		private set
		{
			_003CPropID_003Ek__BackingField = value;
		}
	}

	public List<object> Delta
	{
		get
		{
			return _003CDelta_003Ek__BackingField;
		}
		private set
		{
			_003CDelta_003Ek__BackingField = value;
		}
	}

	public bool Switch
	{
		get
		{
			return _003CSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CSwitch_003Ek__BackingField = value;
		}
	}

	public int StartTickCount
	{
		get
		{
			return _003CStartTickCount_003Ek__BackingField;
		}
		private set
		{
			_003CStartTickCount_003Ek__BackingField = value;
		}
	}

	public object DeltaValue
	{
		get
		{
			return _003CDeltaValue_003Ek__BackingField;
		}
		private set
		{
			_003CDeltaValue_003Ek__BackingField = value;
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

	public UGCPlayableRelativeFrameRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
