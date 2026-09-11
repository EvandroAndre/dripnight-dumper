using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMoreTeamLeaderboardHudV2RepItem
{
	public const int PROP_ID_OPENSTATE = -438000;

	public const int PROP_ID_PLAYERS = -438001;

	public const int PROP_ID_RANKS = -438002;

	public const int PROP_ID_TOTALSCORES = -438003;

	public const int PROP_ID_SCORETYPENAMES = -438004;

	public const int PROP_ID_COLORS = -438005;

	public const int PROP_ID_SCORES = -438006;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<List<object>> OnPlayersChangeEvent;

	public Action<List<object>> OnRanksChangeEvent;

	public Action<List<object>> OnTotalScoresChangeEvent;

	public Action<List<object>> OnScoreTypeNamesChangeEvent;

	public Action<List<object>> OnColorsChangeEvent;

	public Action<List<object>> OnScoresChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private List<object> _003CPlayers_003Ek__BackingField;

	private List<object> _003CRanks_003Ek__BackingField;

	private List<object> _003CTotalScores_003Ek__BackingField;

	private List<object> _003CScoreTypeNames_003Ek__BackingField;

	private List<object> _003CColors_003Ek__BackingField;

	private List<object> _003CScores_003Ek__BackingField;

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

	public List<object> Ranks
	{
		get
		{
			return _003CRanks_003Ek__BackingField;
		}
		private set
		{
			_003CRanks_003Ek__BackingField = value;
		}
	}

	public List<object> TotalScores
	{
		get
		{
			return _003CTotalScores_003Ek__BackingField;
		}
		private set
		{
			_003CTotalScores_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreTypeNames
	{
		get
		{
			return _003CScoreTypeNames_003Ek__BackingField;
		}
		private set
		{
			_003CScoreTypeNames_003Ek__BackingField = value;
		}
	}

	public List<object> Colors
	{
		get
		{
			return _003CColors_003Ek__BackingField;
		}
		private set
		{
			_003CColors_003Ek__BackingField = value;
		}
	}

	public List<object> Scores
	{
		get
		{
			return _003CScores_003Ek__BackingField;
		}
		private set
		{
			_003CScores_003Ek__BackingField = value;
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

	public UGCMoreTeamLeaderboardHudV2RepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
