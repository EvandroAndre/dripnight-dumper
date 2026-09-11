using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSingleLeaderboardHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1034000;

	public const int PROP_ID_PLAYERS = -1034001;

	public const int PROP_ID_PLAYERRANKS = -1034002;

	public const int PROP_ID_PLAYERSCORETYPES = -1034003;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<List<object>> OnPlayersChangeEvent;

	public Action<List<object>> OnPlayerRanksChangeEvent;

	public Action<List<object>> OnPlayerScoreTypesChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private List<object> _003CPlayers_003Ek__BackingField;

	private List<object> _003CPlayerRanks_003Ek__BackingField;

	private List<object> _003CPlayerScoreTypes_003Ek__BackingField;

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

	public List<object> Players
	{
		get
		{
			return _003CPlayers_003Ek__BackingField;
		}
		private set
		{
			_003CPlayers_003Ek__BackingField = value;
		}
	}

	public List<object> PlayerRanks
	{
		get
		{
			return _003CPlayerRanks_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerRanks_003Ek__BackingField = value;
		}
	}

	public List<object> PlayerScoreTypes
	{
		get
		{
			return _003CPlayerScoreTypes_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerScoreTypes_003Ek__BackingField = value;
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

	public UGCSingleLeaderboardHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
