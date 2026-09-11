using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMultiTeamMatchResultHudRepItem
{
	public const int PROP_ID_OPENSTATE = -193000;

	public const int PROP_ID_MATCHTITLE1 = -193001;

	public const int PROP_ID_MATCHTITLE2 = -193002;

	public const int PROP_ID_RESULT = -193003;

	public const int PROP_ID_TEAMRANK = -193004;

	public const int PROP_ID_PLAYERRANK = -193005;

	public const int PROP_ID_TEAMRANK4DISPLAY = -193006;

	public const int PROP_ID_MAINSCORETITLE = -193007;

	public const int PROP_ID_MAINSCORELIST = -193008;

	public const int PROP_ID_TITLELIST = -193009;

	public const int PROP_ID_SCORELIST1 = -193010;

	public const int PROP_ID_SCORELIST2 = -193011;

	public const int PROP_ID_SCORELIST3 = -193012;

	public const int PROP_ID_SCORELIST4 = -193013;

	public const int PROP_ID_SCORELIST5 = -193014;

	public const int PROP_ID_WINMVPLIST = -193015;

	public const int PROP_ID_LOSEMVPLIST = -193016;

	public const int PROP_ID_SHOWMATCHDETAIL = -193017;

	public const int PROP_ID_SHOWMAPEVALUATE = -193018;

	public const int PROP_ID_SHOWGIFT = -193019;

	public const int PROP_ID_SHOWREPORT = -193020;

	public const int PROP_ID_SHOWREPLAY = -193021;

	public const int PROP_ID_SHOWSHARE = -193022;

	public const int PROP_ID_SHOWLOBBY = -193023;

	public const int PROP_ID_SHOWLIKE = -193024;

	public const int PROP_ID_SHOWFRIEND = -193025;

	public const int PROP_ID_SHOWECCONOMY = -193026;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnMatchTitle1ChangeEvent;

	public Action<string> OnMatchTitle2ChangeEvent;

	public Action<int> OnResultChangeEvent;

	public Action<List<object>> OnTeamRankChangeEvent;

	public Action<List<object>> OnPlayerRankChangeEvent;

	public Action<List<object>> OnTeamRank4DisplayChangeEvent;

	public Action<string> OnMainScoreTitleChangeEvent;

	public Action<List<object>> OnMainScoreListChangeEvent;

	public Action<List<object>> OnTitleListChangeEvent;

	public Action<List<object>> OnScoreList1ChangeEvent;

	public Action<List<object>> OnScoreList2ChangeEvent;

	public Action<List<object>> OnScoreList3ChangeEvent;

	public Action<List<object>> OnScoreList4ChangeEvent;

	public Action<List<object>> OnScoreList5ChangeEvent;

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

	private string _003CMatchTitle1_003Ek__BackingField;

	private string _003CMatchTitle2_003Ek__BackingField;

	private int _003CResult_003Ek__BackingField;

	private List<object> _003CTeamRank_003Ek__BackingField;

	private List<object> _003CPlayerRank_003Ek__BackingField;

	private List<object> _003CTeamRank4Display_003Ek__BackingField;

	private string _003CMainScoreTitle_003Ek__BackingField;

	private List<object> _003CMainScoreList_003Ek__BackingField;

	private List<object> _003CTitleList_003Ek__BackingField;

	private List<object> _003CScoreList1_003Ek__BackingField;

	private List<object> _003CScoreList2_003Ek__BackingField;

	private List<object> _003CScoreList3_003Ek__BackingField;

	private List<object> _003CScoreList4_003Ek__BackingField;

	private List<object> _003CScoreList5_003Ek__BackingField;

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

	public string MatchTitle1
	{
		get
		{
			return _003CMatchTitle1_003Ek__BackingField;
		}
		private set
		{
			_003CMatchTitle1_003Ek__BackingField = value;
		}
	}

	public string MatchTitle2
	{
		get
		{
			return _003CMatchTitle2_003Ek__BackingField;
		}
		private set
		{
			_003CMatchTitle2_003Ek__BackingField = value;
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

	public List<object> TeamRank
	{
		get
		{
			return _003CTeamRank_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRank_003Ek__BackingField = value;
		}
	}

	public List<object> PlayerRank
	{
		get
		{
			return _003CPlayerRank_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerRank_003Ek__BackingField = value;
		}
	}

	public List<object> TeamRank4Display
	{
		get
		{
			return _003CTeamRank4Display_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRank4Display_003Ek__BackingField = value;
		}
	}

	public string MainScoreTitle
	{
		get
		{
			return _003CMainScoreTitle_003Ek__BackingField;
		}
		private set
		{
			_003CMainScoreTitle_003Ek__BackingField = value;
		}
	}

	public List<object> MainScoreList
	{
		get
		{
			return _003CMainScoreList_003Ek__BackingField;
		}
		private set
		{
			_003CMainScoreList_003Ek__BackingField = value;
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

	public List<object> ScoreList4
	{
		get
		{
			return _003CScoreList4_003Ek__BackingField;
		}
		private set
		{
			_003CScoreList4_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreList5
	{
		get
		{
			return _003CScoreList5_003Ek__BackingField;
		}
		private set
		{
			_003CScoreList5_003Ek__BackingField = value;
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

	public UGCMultiTeamMatchResultHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
