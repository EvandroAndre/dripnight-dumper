using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTweenTipsHudRepItem
{
	public const int PROP_ID_LOCSWITCH = -1032000;

	public const int PROP_ID_EVENTTIPSTYPE = -1032001;

	public const int PROP_ID_DESCRIPTION = -1032002;

	public const int PROP_ID_PARAMS = -1032003;

	public const int PROP_ID_OPENSTATE = -1032004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<int> OnEventTipsTypeChangeEvent;

	public Action<string> OnDescriptionChangeEvent;

	public Action<List<object>> OnParamsChangeEvent;

	public Action<bool> OnOpenStateChangeEvent;

	private bool _003CLocSwitch_003Ek__BackingField;

	private int _003CEventTipsType_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private List<object> _003CParams_003Ek__BackingField;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool LocSwitch
	{
		get
		{
			return _003CLocSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CLocSwitch_003Ek__BackingField = value;
		}
	}

	public int EventTipsType
	{
		get
		{
			return _003CEventTipsType_003Ek__BackingField;
		}
		private set
		{
			_003CEventTipsType_003Ek__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		private set
		{
			_003CDescription_003Ek__BackingField = value;
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

	public UGCTweenTipsHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
