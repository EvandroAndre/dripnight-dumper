using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayableSelfRelativeRepItem
{
	public const int PROP_ID_TARGETENTITY = -330000;

	public const int PROP_ID_PROPID = -330001;

	public const int PROP_ID_DELTA = -330002;

	public const int PROP_ID_STYLE = -330003;

	public const int PROP_ID_DURATION = -330004;

	public const int PROP_ID_CONTROLPOINTS = -330005;

	public const int PROP_ID_STARTTICKCOUNT = -330007;

	public const int PROP_ID_DELTAVALUE = -330008;

	public const int PROP_ID_ELAPSEDPERCENTAGE = -330009;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<long> OnPropIDChangeEvent;

	public Action<List<object>> OnDeltaChangeEvent;

	public Action<int> OnStyleChangeEvent;

	public Action<float> OnDurationChangeEvent;

	public Action<List<object>> OnControlPointsChangeEvent;

	public Action<int> OnStartTickCountChangeEvent;

	public Action<object> OnDeltaValueChangeEvent;

	public Action<float> OnElapsedPercentageChangeEvent;

	private string _003CTargetEntity_003Ek__BackingField;

	private long _003CPropID_003Ek__BackingField;

	private List<object> _003CDelta_003Ek__BackingField;

	private int _003CStyle_003Ek__BackingField;

	private float _003CDuration_003Ek__BackingField;

	private List<object> _003CControlPoints_003Ek__BackingField;

	private int _003CStartTickCount_003Ek__BackingField;

	private object _003CDeltaValue_003Ek__BackingField;

	private float _003CElapsedPercentage_003Ek__BackingField;

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

	public int Style
	{
		get
		{
			return _003CStyle_003Ek__BackingField;
		}
		private set
		{
			_003CStyle_003Ek__BackingField = value;
		}
	}

	public float Duration
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

	public List<object> ControlPoints
	{
		get
		{
			return _003CControlPoints_003Ek__BackingField;
		}
		private set
		{
			_003CControlPoints_003Ek__BackingField = value;
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

	public float ElapsedPercentage
	{
		get
		{
			return _003CElapsedPercentage_003Ek__BackingField;
		}
		private set
		{
			_003CElapsedPercentage_003Ek__BackingField = value;
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

	public UGCPlayableSelfRelativeRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
