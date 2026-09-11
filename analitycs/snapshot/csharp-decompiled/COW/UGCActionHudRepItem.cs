using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCActionHudRepItem
{
	public const int PROP_ID_OPENSTATE = -83000;

	public const int PROP_ID_ENTITYID = -83001;

	public const int PROP_ID_PARAMS = -83002;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnEntityIDChangeEvent;

	public Action<List<object>> OnParamsChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CEntityID_003Ek__BackingField;

	private List<object> _003CParams_003Ek__BackingField;

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

	public string EntityID
	{
		get
		{
			return _003CEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CEntityID_003Ek__BackingField = value;
		}
	}

	public List<object> Params
	{
		get
		{
			return _003CParams_003Ek__BackingField;
		}
		private set
		{
			_003CParams_003Ek__BackingField = value;
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

	public UGCActionHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
