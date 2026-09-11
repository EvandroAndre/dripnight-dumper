using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCKillOrGodZoneTriggerRepItem
{
	public const int PROP_ID_ISKILLZONE = -2502000;

	public const int PROP_ID_SHOWORHIDE = -2502001;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnIsKillZoneChangeEvent;

	public Action<bool> OnShowOrHideChangeEvent;

	private bool _003CIsKillZone_003Ek__BackingField;

	private bool _003CShowOrHide_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool IsKillZone
	{
		get
		{
			return _003CIsKillZone_003Ek__BackingField;
		}
		private set
		{
			_003CIsKillZone_003Ek__BackingField = value;
		}
	}

	public bool ShowOrHide
	{
		get
		{
			return _003CShowOrHide_003Ek__BackingField;
		}
		private set
		{
			_003CShowOrHide_003Ek__BackingField = value;
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

	public UGCKillOrGodZoneTriggerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
