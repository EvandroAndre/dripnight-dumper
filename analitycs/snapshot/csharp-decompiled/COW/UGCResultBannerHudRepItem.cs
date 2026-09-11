using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCResultBannerHudRepItem
{
	public const int PROP_ID_LOCSWITCH = -1019000;

	public const int PROP_ID_RESULT = -1019001;

	public const int PROP_ID_OPENSTATE = -1019002;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<int> OnResultChangeEvent;

	public Action<bool> OnOpenStateChangeEvent;

	private bool _003CLocSwitch_003Ek__BackingField;

	private int _003CResult_003Ek__BackingField;

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

	public int Result
	{
		get
		{
			return _003CResult_003Ek__BackingField;
		}
		private set
		{
			_003CResult_003Ek__BackingField = value;
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

	public UGCResultBannerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
