using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCFiveSecondCountDownHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1042000;

	public const int PROP_ID_LOCALPOSITION = -1042001;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<Vector3> OnLocalPositionChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private Vector3 _003CLocalPosition_003Ek__BackingField;

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

	public Vector3 LocalPosition
	{
		get
		{
			return _003CLocalPosition_003Ek__BackingField;
		}
		private set
		{
			_003CLocalPosition_003Ek__BackingField = value;
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

	public UGCFiveSecondCountDownHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
