using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamMatchResultHudRepItem
{
	public const int PROP_ID_OPENSTATE = -190000;

	public const int PROP_ID_RESULT = -190001;

	public const int PROP_ID_LEFTTEAMNAME = -190002;

	public const int PROP_ID_RIGHTTEAMNAME = -190003;

	public const int PROP_ID_LEFTTEAM = -190004;

	public const int PROP_ID_RIGHTTEAM = -190005;

	public const int PROP_ID_PLAYERLIST = -190006;

	public const int PROP_ID_LEFTTEAMSCORE = -190007;

	public const int PROP_ID_RIGHTTEAMSCORE = -190008;

	public const int PROP_ID_TITLELIST = -190009;

	public const int PROP_ID_SCORELIST1 = -190010;

	public const int PROP_ID_SCORELIST2 = -190011;

	public const int PROP_ID_SCORELIST3 = -190012;

	public const int PROP_ID_WINMVPLIST = -190013;

	public const int PROP_ID_LOSEMVPLIST = -190014;

	public const int PROP_ID_SHOWMATCHDETAIL = -190015;

	public const int PROP_ID_SHOWMAPEVALUATE = -190016;

	public const int PROP_ID_SHOWGIFT = -190017;

	public const int PROP_ID_SHOWREPORT = -190018;

	public const int PROP_ID_SHOWREPLAY = -190019;

	public const int PROP_ID_SHOWSHARE = -190020;

	public const int PROP_ID_SHOWLOBBY = -190021;

	public const int PROP_ID_SHOWLIKE = -190022;

	public const int PROP_ID_SHOWFRIEND = -190023;

	public const int PROP_ID_SHOWECCONOMY = -190024;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnResultChangeEvent;

	public Action<string> OnLeftTeamNameChangeEvent;

	public Action<string> OnRightTeamNameChangeEvent;

	public Action<string> OnLeftTeamChangeEvent;

	public Action<string> OnRightTeamChangeEvent;

	public Action<List<object>> OnPlayerListChangeEvent;

	public Action<string> OnLeftTeamScoreChangeEvent;

	public Action<string> OnRightTeamScoreChangeEvent;

	public Action<List<object>> OnTitleListChangeEvent;

	public Action<List<object>> OnScoreList1ChangeEvent;

	public Action<List<object>> OnScoreList2ChangeEvent;

	public Action<List<object>> OnScoreList3ChangeEvent;

	public Action<List<object>> OnWinMVPListChangeEvent;

	public Action<List<object>> OnLoseMVPListChangeEvent;

	public Action<bool> OnShowMatchDetailChangeEvent;

	public Action<bool> OnShowMapEvaluateChangeEvent;

	public Action<bool> OnShowGiftChangeEvent;

	public Action<bool> OnShowReportChangeEvent;

	public Action<bool> OnShowReplayChangeEvent;

	public Action<bool> OnShowShareChangeEvent;

	public Action<bool> OnShowLobbyChangeEvent;

	public Action<bool> OnShowLikeChangeEvent;

	public Action<bool> OnShowFriendChangeEvent;

	public Action<bool> OnShowEcconomyChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CResult_003Ek__BackingField;

	private string _003CLeftTeamName_003Ek__BackingField;

	private string _003CRightTeamName_003Ek__BackingField;

	private string _003CLeftTeam_003Ek__BackingField;

	private string _003CRightTeam_003Ek__BackingField;

	private List<object> _003CPlayerList_003Ek__BackingField;

	private string _003CLeftTeamScore_003Ek__BackingField;

	private string _003CRightTeamScore_003Ek__BackingField;

	private List<object> _003CTitleList_003Ek__BackingField;

	private List<object> _003CScoreList1_003Ek__BackingField;

	private List<object> _003CScoreList2_003Ek__BackingField;

	private List<object> _003CScoreList3_003Ek__BackingField;

	private List<object> _003CWinMVPList_003Ek__BackingField;

	private List<object> _003CLoseMVPList_003Ek__BackingField;

	private bool _003CShowMatchDetail_003Ek__BackingField;

	private bool _003CShowMapEvaluate_003Ek__BackingField;

	private bool _003CShowGift_003Ek__BackingField;

	private bool _003CShowReport_003Ek__BackingField;

	private bool _003CShowReplay_003Ek__BackingField;

	private bool _003CShowShare_003Ek__BackingField;

	private bool _003CShowLobby_003Ek__BackingField;

	private bool _003CShowLike_003Ek__BackingField;

	private bool _003CShowFriend_003Ek__BackingField;

	private bool _003CShowEcconomy_003Ek__BackingField;

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

	public string LeftTeam
	{
		get
		{
			return _003CLeftTeam_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeam_003Ek__BackingField = value;
		}
	}

	public string RightTeam
	{
		get
		{
			return _003CRightTeam_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeam_003Ek__BackingField = value;
		}
	}

	public List<object> PlayerList
	{
		get
		{
			return _003CPlayerList_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerList_003Ek__BackingField = value;
		}
	}

	public string LeftTeamScore
	{
		get
		{
			return _003CLeftTeamScore_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeamScore_003Ek__BackingField = value;
		}
	}

	public string RightTeamScore
	{
		get
		{
			return _003CRightTeamScore_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeamScore_003Ek__BackingField = value;
		}
	}

	public List<object> TitleList
	{
		get
		{
			return _003CTitleList_003Ek__BackingField;
		}
		private set
		{
			_003CTitleList_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreList1
	{
		get
		{
			return _003CScoreList1_003Ek__BackingField;
		}
		private set
		{
			_003CScoreList1_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreList2
	{
		get
		{
			return _003CScoreList2_003Ek__BackingField;
		}
		private set
		{
			_003CScoreList2_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreList3
	{
		get
		{
			return _003CScoreList3_003Ek__BackingField;
		}
		private set
		{
			_003CScoreList3_003Ek__BackingField = value;
		}
	}

	public List<object> WinMVPList
	{
		get
		{
			return _003CWinMVPList_003Ek__BackingField;
		}
		private set
		{
			_003CWinMVPList_003Ek__BackingField = value;
		}
	}

	public List<object> LoseMVPList
	{
		get
		{
			return _003CLoseMVPList_003Ek__BackingField;
		}
		private set
		{
			_003CLoseMVPList_003Ek__BackingField = value;
		}
	}

	public bool ShowMatchDetail
	{
		get
		{
			return _003CShowMatchDetail_003Ek__BackingField;
		}
		private set
		{
			_003CShowMatchDetail_003Ek__BackingField = value;
		}
	}

	public bool ShowMapEvaluate
	{
		get
		{
			return _003CShowMapEvaluate_003Ek__BackingField;
		}
		private set
		{
			_003CShowMapEvaluate_003Ek__BackingField = value;
		}
	}

	public bool ShowGift
	{
		get
		{
			return _003CShowGift_003Ek__BackingField;
		}
		private set
		{
			_003CShowGift_003Ek__BackingField = value;
		}
	}

	public bool ShowReport
	{
		get
		{
			return _003CShowReport_003Ek__BackingField;
		}
		private set
		{
			_003CShowReport_003Ek__BackingField = value;
		}
	}

	public bool ShowReplay
	{
		get
		{
			return _003CShowReplay_003Ek__BackingField;
		}
		private set
		{
			_003CShowReplay_003Ek__BackingField = value;
		}
	}

	public bool ShowShare
	{
		get
		{
			return _003CShowShare_003Ek__BackingField;
		}
		private set
		{
			_003CShowShare_003Ek__BackingField = value;
		}
	}

	public bool ShowLobby
	{
		get
		{
			return _003CShowLobby_003Ek__BackingField;
		}
		private set
		{
			_003CShowLobby_003Ek__BackingField = value;
		}
	}

	public bool ShowLike
	{
		get
		{
			return _003CShowLike_003Ek__BackingField;
		}
		private set
		{
			_003CShowLike_003Ek__BackingField = value;
		}
	}

	public bool ShowFriend
	{
		get
		{
			return _003CShowFriend_003Ek__BackingField;
		}
		private set
		{
			_003CShowFriend_003Ek__BackingField = value;
		}
	}

	public bool ShowEcconomy
	{
		get
		{
			return _003CShowEcconomy_003Ek__BackingField;
		}
		private set
		{
			_003CShowEcconomy_003Ek__BackingField = value;
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

	public UGCTwoTeamMatchResultHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
