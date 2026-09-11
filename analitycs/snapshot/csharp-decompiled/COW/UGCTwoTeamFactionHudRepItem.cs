using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamFactionHudRepItem
{
	public const int PROP_ID_LOCSWITCH = -1017000;

	public const int PROP_ID_LEFTTEAMNAME = -1017001;

	public const int PROP_ID_LEFTTEAMDESC = -1017002;

	public const int PROP_ID_RIGHTTEAMNAME = -1017003;

	public const int PROP_ID_RIGHTTEAMDESC = -1017004;

	public const int PROP_ID_OPENSTATE = -1017005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnLeftTeamNameChangeEvent;

	public Action<string> OnLeftTeamDescChangeEvent;

	public Action<string> OnRightTeamNameChangeEvent;

	public Action<string> OnRightTeamDescChangeEvent;

	public Action<bool> OnOpenStateChangeEvent;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CLeftTeamName_003Ek__BackingField;

	private string _003CLeftTeamDesc_003Ek__BackingField;

	private string _003CRightTeamName_003Ek__BackingField;

	private string _003CRightTeamDesc_003Ek__BackingField;

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

	public string LeftTeamName
	{
		get
		{
			return _003CLeftTeamName_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeamName_003Ek__BackingField = value;
		}
	}

	public string LeftTeamDesc
	{
		get
		{
			return _003CLeftTeamDesc_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeamDesc_003Ek__BackingField = value;
		}
	}

	public string RightTeamName
	{
		get
		{
			return _003CRightTeamName_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeamName_003Ek__BackingField = value;
		}
	}

	public string RightTeamDesc
	{
		get
		{
			return _003CRightTeamDesc_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeamDesc_003Ek__BackingField = value;
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

	public UGCTwoTeamFactionHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
