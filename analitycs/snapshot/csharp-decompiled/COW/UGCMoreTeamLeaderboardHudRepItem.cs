using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMoreTeamLeaderboardHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1026000;

	public const int PROP_ID_TEAMINDEXS = -1026001;

	public const int PROP_ID_TEAMRANKS = -1026002;

	public const int PROP_ID_TEAMSCORES = -1026003;

	public const int PROP_ID_TEAMCOLORS = -1026004;

	public const int PROP_ID_PLAYERSCORETYPES = -1026005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<List<object>> OnTeamIndexsChangeEvent;

	public Action<List<object>> OnTeamRanksChangeEvent;

	public Action<List<object>> OnTeamScoresChangeEvent;

	public Action<List<object>> OnTeamColorsChangeEvent;

	public Action<List<object>> OnPlayerScoreTypesChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private List<object> _003CTeamIndexs_003Ek__BackingField;

	private List<object> _003CTeamRanks_003Ek__BackingField;

	private List<object> _003CTeamScores_003Ek__BackingField;

	private List<object> _003CTeamColors_003Ek__BackingField;

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

	public List<object> TeamIndexs
	{
		get
		{
			return _003CTeamIndexs_003Ek__BackingField;
		}
		private set
		{
			_003CTeamIndexs_003Ek__BackingField = value;
		}
	}

	public List<object> TeamRanks
	{
		get
		{
			return _003CTeamRanks_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRanks_003Ek__BackingField = value;
		}
	}

	public List<object> TeamScores
	{
		get
		{
			return _003CTeamScores_003Ek__BackingField;
		}
		private set
		{
			_003CTeamScores_003Ek__BackingField = value;
		}
	}

	public List<object> TeamColors
	{
		get
		{
			return _003CTeamColors_003Ek__BackingField;
		}
		private set
		{
			_003CTeamColors_003Ek__BackingField = value;
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

	public UGCMoreTeamLeaderboardHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
