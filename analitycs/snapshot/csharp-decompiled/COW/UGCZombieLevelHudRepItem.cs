using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCZombieLevelHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1036000;

	public const int PROP_ID_TOTALLEVEL = -1036001;

	public const int PROP_ID_LEVEL = -1036002;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnTotalLevelChangeEvent;

	public Action<int> OnLevelChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CTotalLevel_003Ek__BackingField;

	private int _003CLevel_003Ek__BackingField;

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

	public int TotalLevel
	{
		get
		{
			return _003CTotalLevel_003Ek__BackingField;
		}
		private set
		{
			_003CTotalLevel_003Ek__BackingField = value;
		}
	}

	public int Level
	{
		get
		{
			return _003CLevel_003Ek__BackingField;
		}
		private set
		{
			_003CLevel_003Ek__BackingField = value;
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

	public UGCZombieLevelHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
