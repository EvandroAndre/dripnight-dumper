using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTweenCurveRepItem
{
	public const int PROP_ID_CONTROLPOINTS = -196000;

	private UGCEntityDataStore _repDataMgr;

	public Action<List<object>> OnControlPointsChangeEvent;

	private List<object> _003CControlPoints_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public UGCTweenCurveRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
