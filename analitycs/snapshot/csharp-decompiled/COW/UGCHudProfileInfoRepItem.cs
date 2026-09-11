using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudProfileInfoRepItem
{
	public const int PROP_ID_SCALE = -323000;

	public const int PROP_ID_ACCOUNTID = -323001;

	public const int PROP_ID_PROFILEINFO = -323002;

	public const int PROP_ID_SHOWTYPE = -323003;

	public const int PROP_ID_SHOWRANK = -323004;

	public const int PROP_ID_SHOWPIN = -323005;

	public const int PROP_ID_SHOWNAME = -323006;

	private UGCEntityDataStore _repDataMgr;

	public Action<Vector3> OnScaleChangeEvent;

	public Action<string> OnAccountIDChangeEvent;

	public Action<string> OnProfileInfoChangeEvent;

	public Action<int> OnShowTypeChangeEvent;

	public Action<int> OnShowRankChangeEvent;

	public Action<bool> OnShowPinChangeEvent;

	public Action<bool> OnShowNameChangeEvent;

	private Vector3 _003CScale_003Ek__BackingField;

	private string _003CAccountID_003Ek__BackingField;

	private string _003CProfileInfo_003Ek__BackingField;

	private int _003CShowType_003Ek__BackingField;

	private int _003CShowRank_003Ek__BackingField;

	private bool _003CShowPin_003Ek__BackingField;

	private bool _003CShowName_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public Vector3 Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
		}
	}

	public string AccountID
	{
		get
		{
			return _003CAccountID_003Ek__BackingField;
		}
		private set
		{
			_003CAccountID_003Ek__BackingField = value;
		}
	}

	public string ProfileInfo
	{
		get
		{
			return _003CProfileInfo_003Ek__BackingField;
		}
		private set
		{
			_003CProfileInfo_003Ek__BackingField = value;
		}
	}

	public int ShowType
	{
		get
		{
			return _003CShowType_003Ek__BackingField;
		}
		private set
		{
			_003CShowType_003Ek__BackingField = value;
		}
	}

	public int ShowRank
	{
		get
		{
			return _003CShowRank_003Ek__BackingField;
		}
		private set
		{
			_003CShowRank_003Ek__BackingField = value;
		}
	}

	public bool ShowPin
	{
		get
		{
			return _003CShowPin_003Ek__BackingField;
		}
		private set
		{
			_003CShowPin_003Ek__BackingField = value;
		}
	}

	public bool ShowName
	{
		get
		{
			return _003CShowName_003Ek__BackingField;
		}
		private set
		{
			_003CShowName_003Ek__BackingField = value;
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

	public UGCHudProfileInfoRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
