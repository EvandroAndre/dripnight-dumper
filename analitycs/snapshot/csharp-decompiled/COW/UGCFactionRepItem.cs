using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCFactionRepItem
{
	public const int PROP_ID_ISACE = -118000;

	public const int PROP_ID_ALLPLAYERS = -118001;

	public const int PROP_ID_FRIENDLYFACTIONS = -118002;

	public const int PROP_ID_HOSTILEFACTIONS = -118003;

	public const int PROP_ID_ISSHOWHUDNAME = -118004;

	public const int PROP_ID_ISSHOWMAPINFO = -118005;

	public const int PROP_ID_ISSHOWTAG = -118006;

	public const int PROP_ID_ISSHOWSCAN = -118007;

	public const int PROP_ID_ALLMEMBERS = -118008;

	public const int PROP_ID_ISSHOWQUICKMESSAGE = -118009;

	private UGCEntityDataStore _repDataMgr;

	public Action<List<object>> OnFriendlyFactionsChangeEvent;

	public Action<List<object>> OnHostileFactionsChangeEvent;

	public Action<bool> OnIsShowHudNameChangeEvent;

	public Action<bool> OnIsShowMapInfoChangeEvent;

	public Action<bool> OnIsShowTagChangeEvent;

	public Action<bool> OnIsShowScanChangeEvent;

	public Action<List<object>> OnAllMembersChangeEvent;

	public Action<bool> OnIsShowQuickMessageChangeEvent;

	private List<object> _003CFriendlyFactions_003Ek__BackingField;

	private List<object> _003CHostileFactions_003Ek__BackingField;

	private bool _003CIsShowHudName_003Ek__BackingField;

	private bool _003CIsShowMapInfo_003Ek__BackingField;

	private bool _003CIsShowTag_003Ek__BackingField;

	private bool _003CIsShowScan_003Ek__BackingField;

	private List<object> _003CAllMembers_003Ek__BackingField;

	private bool _003CIsShowQuickMessage_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public List<object> FriendlyFactions
	{
		get
		{
			return _003CFriendlyFactions_003Ek__BackingField;
		}
		private set
		{
			_003CFriendlyFactions_003Ek__BackingField = value;
		}
	}

	public List<object> HostileFactions
	{
		get
		{
			return _003CHostileFactions_003Ek__BackingField;
		}
		private set
		{
			_003CHostileFactions_003Ek__BackingField = value;
		}
	}

	public bool IsShowHudName
	{
		get
		{
			return _003CIsShowHudName_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowHudName_003Ek__BackingField = value;
		}
	}

	public bool IsShowMapInfo
	{
		get
		{
			return _003CIsShowMapInfo_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowMapInfo_003Ek__BackingField = value;
		}
	}

	public bool IsShowTag
	{
		get
		{
			return _003CIsShowTag_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowTag_003Ek__BackingField = value;
		}
	}

	public bool IsShowScan
	{
		get
		{
			return _003CIsShowScan_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowScan_003Ek__BackingField = value;
		}
	}

	public List<object> AllMembers
	{
		get
		{
			return _003CAllMembers_003Ek__BackingField;
		}
		private set
		{
			_003CAllMembers_003Ek__BackingField = value;
		}
	}

	public bool IsShowQuickMessage
	{
		get
		{
			return _003CIsShowQuickMessage_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowQuickMessage_003Ek__BackingField = value;
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

	public UGCFactionRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
