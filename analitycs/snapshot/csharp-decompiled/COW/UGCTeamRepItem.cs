using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTeamRepItem
{
	public const int PROP_ID_ISACE = -15000;

	public const int PROP_ID_ALLPLAYERS = -15001;

	public const int PROP_ID_TEAMINDEX = -15002;

	public const int PROP_ID_HOSTILETEAMS = -15003;

	public const int PROP_ID_FRIENDLYTEAMS = -15004;

	public const int PROP_ID_TEAMSEQ = -15005;

	public const int PROP_ID_ISSHOWHUDNAME = -15006;

	private UGCEntityDataStore _repDataMgr;

	public Action<List<object>> OnHostileTeamsChangeEvent;

	public Action<List<object>> OnFriendlyTeamsChangeEvent;

	public Action<bool> OnIsShowHudNameChangeEvent;

	private List<object> _003CHostileTeams_003Ek__BackingField;

	private List<object> _003CFriendlyTeams_003Ek__BackingField;

	private bool _003CIsShowHudName_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public List<object> HostileTeams
	{
		get
		{
			return _003CHostileTeams_003Ek__BackingField;
		}
		private set
		{
			_003CHostileTeams_003Ek__BackingField = value;
		}
	}

	public List<object> FriendlyTeams
	{
		get
		{
			return _003CFriendlyTeams_003Ek__BackingField;
		}
		private set
		{
			_003CFriendlyTeams_003Ek__BackingField = value;
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

	public UGCTeamRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
