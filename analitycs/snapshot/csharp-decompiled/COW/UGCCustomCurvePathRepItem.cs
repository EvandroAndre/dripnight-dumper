using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCustomCurvePathRepItem
{
	public const int PROP_ID_PATHTYPE = -434000;

	public const int PROP_ID_LENGTH = -434001;

	public const int PROP_ID_CLOSEDLOOP = -434002;

	public const int PROP_ID_WAYPOINTS = -434003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnPathTypeChangeEvent;

	public Action<float> OnLengthChangeEvent;

	public Action<bool> OnClosedLoopChangeEvent;

	public Action<List<object>> OnWayPointsChangeEvent;

	private int _003CPathType_003Ek__BackingField;

	private float _003CLength_003Ek__BackingField;

	private bool _003CClosedLoop_003Ek__BackingField;

	private List<object> _003CWayPoints_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int PathType
	{
		get
		{
			return _003CPathType_003Ek__BackingField;
		}
		private set
		{
			_003CPathType_003Ek__BackingField = value;
		}
	}

	public float Length
	{
		get
		{
			return _003CLength_003Ek__BackingField;
		}
		private set
		{
			_003CLength_003Ek__BackingField = value;
		}
	}

	public bool ClosedLoop
	{
		get
		{
			return _003CClosedLoop_003Ek__BackingField;
		}
		private set
		{
			_003CClosedLoop_003Ek__BackingField = value;
		}
	}

	public List<object> WayPoints
	{
		get
		{
			return _003CWayPoints_003Ek__BackingField;
		}
		private set
		{
			_003CWayPoints_003Ek__BackingField = value;
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

	public UGCCustomCurvePathRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
